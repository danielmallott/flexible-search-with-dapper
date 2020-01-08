CREATE PROCEDURE Sales.SearchOrders
    @customerID INT = NULL
    ,@salesPersonID INT = NULL
    ,@contactPersonID INT = NULL
    ,@orderDate DATE = NULL
    ,@expectedDeliveryDate DATE = NULL
    ,@customerPurchaseOrderNumber NVARCHAR(20) = NULL
    ,@stockItemID INT = NULL
    ,@description NVARCHAR(100) = NULL
    ,@quantity INT = NULL
    ,@unitPrice DECIMAL(18,2) = NULL
    ,@debug TINYINT = 0 -- 0 = No debugging, 1 = Prints and selects individual dynamic variables, 2 = Prints full sp_executesql command
AS
BEGIN

    SET NOCOUNT ON;

    DECLARE @sql NVARCHAR(MAX);

    -- Set our base SQL.
    -- Idea is we want all orders and order lines that fit the criteria
    SET @sql = '
            SELECT O.OrderID
                ,O.CustomerID
                ,O.SalespersonPersonID
                ,O.PickedByPersonID
                ,O.ContactPersonID
                ,O.BackorderOrderID
                ,O.OrderDate
                ,O.ExpectedDeliveryDate
                ,O.CustomerPurchaseOrderNumber
                ,O.IsUndersupplyBackordered
                ,O.Comments
                ,O.DeliveryInstructions
                ,O.InternalComments
                ,O.PickingCompletedWhen
                ,O.LastEditedBy
                ,O.LastEditedWhen
                ,OL.OrderLineID
                ,OL.OrderID
                ,OL.StockItemID
                ,OL.Description
                ,OL.PackageTypeID
                ,OL.Quantity
                ,OL.UnitPrice
                ,OL.TaxRate
                ,OL.PickedQuantity
                ,OL.PickingCompletedWhen
                ,OL.LastEditedBy
                ,OL.LastEditedWhen
            FROM Sales.Orders AS O LEFT JOIN Sales.OrderLines AS OL ON O.OrderID = OL.OrderID ';
    
    DECLARE @whereParameters TABLE (WhereParameter VARCHAR(200) NOT NULL);

    -- If supplied with a Customer ID, add that to the where parameters
    IF (@customerID IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' O.CustomerID = @customerID ';

    -- If supplied with a Salesperson ID, add that to the where parameters
    IF (@salesPersonID IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' O.SalespersonPersonID = @salesPersonID ';

    -- If supplied with a Contact Person ID, add that to the where parameters
    IF (@contactPersonID IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' O.ContactPersonID = @contactPersonID ';

    -- If supplied with an Order Date, add that to the where parameters
    IF (@orderDate IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' O.OrderDate = @orderDate ';

    -- If supplied with an Expected Delivery Date, add that to the where parameters
    IF (@expectedDeliveryDate IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' O.ExpectedDeliveryDate = @expectedDeliveryDate ';

    -- If supplied with a Customer Purchase Order Number, add that to the where parameters
    IF (@customerPurchaseOrderNumber IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' O.CustomerPurchaseOrderNumber = @customerPurchaseOrderNumber ';

    -- If supplied with a Stock Item ID, add that to the where parameters
    IF (@stockItemID IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' OL.StockItemID = @stockItemID ';
    
    -- If supplied with a Description, add that to the where parameters
    IF (@description IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' OL.Description = @description ';

    -- If supplied with a Quantity, add that to the where parameters
    IF (@quantity IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' OL.Quantity = @quantity ';

    -- If supplied with a Unit Price, add that to the where parameters
    IF (@unitPrice IS NOT NULL)
        INSERT INTO @whereParameters
        SELECT ' OL.UnitPrice = @unitPrice ';

    -- If we have any where parameters, concatenate them and add a where clause to the
	-- base SQL statement.
	IF (
			SELECT COUNT(1)
			FROM @whereParameters
			) > 0
	BEGIN
		DECLARE @whereClause NVARCHAR(MAX) = '';

		SELECT @whereClause = COALESCE(@whereClause + WhereParameter + ' AND ', '')
		FROM @whereParameters;

		SET @whereClause = 'WHERE' + LEFT(@whereClause, LEN(@whereClause) - 4);
		SET @sql = @sql + @whereClause;
	END;

	-- Declare and hydrate the parameters list.
	-- Even if the particular parameter is not included in the query, we can still include it in the parameters list.
	-- sp_executesql will happily ignore it.
	DECLARE @params NVARCHAR(MAX);

	SET @params = N'@customerID INT, @salesPersonID INT, @contactPersonID INT, @orderDate DATE, @expectedDeliveryDate DATE, @customerPurchaseOrderNumber NVARCHAR(20), @stockItemID INT, @description NVARCHAR(100), @quantity INT, @unitPrice DECIMAL(18,2)';

	IF (@Debug = 1)
	BEGIN
		PRINT 'SQL:';
		PRINT @sql;
		PRINT 'Params:';
		PRINT @params;

		SELECT @sql as [SQL];
		SELECT @params as [PARAMS];
	END;

	IF (@Debug = 2)
	BEGIN
		PRINT 'sp_executesql statement:';
		PRINT N'EXEC sp_executesql N''' + @sql + N'''' +
			  N', N''' + @params + N'''' +
			  N', ' + CASE WHEN @customerID IS NULL THEN N'NULL' ELSE N'''' + CAST(@customerID AS NVARCHAR(20)) + N'''' END +
			  N', ' + CASE WHEN @salesPersonID IS NULL THEN N'NULL' ELSE N'''' + CAST(@salesPersonID AS NVARCHAR(20)) + N'''' END +
			  N', ' + CASE WHEN @contactPersonID IS NULL THEN N'NULL' ELSE N'''' + CAST(@contactPersonID AS NVARCHAR(20)) + N'''' END +
			  N', ' + CASE WHEN @orderDate IS NULL THEN N'NULL' ELSE N'''' + CAST(@orderDate AS NVARCHAR(20)) + N'''' END +
			  N', ' + CASE WHEN @expectedDeliveryDate IS NULL THEN N'NULL' ELSE N'''' + CAST(@expectedDeliveryDate AS NVARCHAR(30)) + N'''' END +
              N', ' + CASE WHEN @customerPurchaseOrderNumber IS NULL THEN N'NULL' ELSE N'''' + @customerPurchaseOrderNumber + N'''' END +
              N', ' + CASE WHEN @stockItemID IS NULL THEN N'NULL' ELSE N'''' + CAST(@stockItemID AS NVARCHAR(20)) + N'''' END +
              N', ' + CASE WHEN @description IS NULL THEN N'NULL' ELSE N'''' + @description + N'''' END +
              N', ' + CASE WHEN @quantity IS NULL THEN N'NULL' ELSE N'''' + CAST(@quantity AS NVARCHAR(20)) + N'''' END +
              N', ' + CASE WHEN @unitPrice IS NULL THEN N'NULL' ELSE N'''' + CAST(@unitPrice AS NVARCHAR(20)) + N'''' END;
	END;

	EXEC sp_executesql @sql
		,@params
		,@customerID
        ,@salesPersonID
        ,@contactPersonID
        ,@orderDate
        ,@expectedDeliveryDate
        ,@customerPurchaseOrderNumber
        ,@stockItemID
        ,@description
        ,@quantity
        ,@unitPrice;

END;