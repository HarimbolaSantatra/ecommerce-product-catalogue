# Product Catalogue Microservices
The *Product Catalogue* microservices, part of the [ecommerce-microservices][1].

## Database
- Tech: MariaDb/MySQL
- **Name**: *product_catalogue*

## API Usage
### Exposed endpoint

Endpoint | HTTP Method | Description | Method name
--- | --- | --- | ---
`/` | get | Test if the service and the others services it depends on are working | Index
`/status` | get | Test if the service is working but return a plain string | GetStatus
`/<productId>` | get | Get a product | GetProduct
`/add` | post | Add a new product to the catalogue | AddProduct

[1]: https://gitlab.com/HarimbolaSantatra/ecommerce-microservices

