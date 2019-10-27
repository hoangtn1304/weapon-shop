package com.source;

public class GunModel {
    private long id;
    private String name;
    private String type;
    private double price;
    private String supplier;

    public GunModel(long id, String name, String type, double price, String supplier) {
        this.id = id;
        this.name = name;
        this.type = type;
        this.price = price;
        this.supplier = supplier;
    }

    public long getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public String getType() {
        return type;
    }

    public double getPrice() {
        return price;
    }

    public String getSupplier() {
        return supplier;
    }

    public void setId(long id) {
        this.id = id;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setType(String type) {
        this.type = type;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public void setSupplier(String supplier) {
        this.supplier = supplier;
    }
}
