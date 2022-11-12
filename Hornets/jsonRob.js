"use strict";
exports.__esModule = true;
exports.AddressModel = void 0;
var objJson = {
    "address_components": [
        {
            "long_name": "Wawrzyniaka",
            "short_name": "Kordeckiego",
            "types": [
                "route"
            ]
        },
        {
            "long_name": "Grunwald",
            "short_name": "Grunwald",
            "types": [
                "sublocality_level_1",
                "sublocality",
                "political"
            ]
        },
        {
            "long_name": "6",
            "short_name": "6",
            "types": [
                "house_number"
            ]
        },
        {
            "long_name": "Poznań",
            "short_name": "Poznań",
            "types": [
                "locality",
                "political"
            ]
        },
        {
            "long_name": "Poznań",
            "short_name": "Poznań",
            "types": [
                "administrative_area_level_2",
                "political"
            ]
        },
    ]
};
var AddressModel = /** @class */ (function () {
    function AddressModel() {
    }
    return AddressModel;
}());
exports.AddressModel = AddressModel;
var mapper = [
    { route: function (element, model) { model.Street = element.long_name; } },
    { house_number: function (element, model) { model.HouseNumber = element.long_name; } },
    { locality: function (element, model) { model.City = element.long_name; } },
];
var addressModel = new AddressModel();
objJson.address_components.forEach(function (element) {
    mapper.forEach(function (mapEl) {
        if (mapEl[element.types[0]] !== undefined) {
            // route => 
            mapEl[element.types[0]](element, addressModel);
        }
    });
});
console.log(addressModel);
