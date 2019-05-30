var productUrl = "/api/products/";

var getProducts = function () {
    sendRequest(productUrl, "GET", null, function (data) {
        model.products.removeAll();
        model.products.push.apply(model.products, data);
    })
};

var deleteProduct = function (id) {
    sendRequest(productUrl + id, "DELETE", null, function () {
        model.products.remove(function (item) {
            return item.id == id;
        })
    });
}

var saveProduct = function (product, successCallback) {
    sendRequest(producturl, "POST", product, function () {
        getProducts();
        if (successCallback) {
            successCallback();
        }
    });
}

