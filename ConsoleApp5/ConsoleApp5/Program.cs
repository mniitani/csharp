Console.WriteLine(
    new WholesalePrice(
        new DoublePrice(
            new WholesalePrice(
                new DoublePrice(
                    new PrimePrice(120)
                    )
                , 80
                )
            )
        , 200
        )
    .getValue()
    );
