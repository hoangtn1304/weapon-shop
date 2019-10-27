package com.source;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.concurrent.atomic.AtomicLong;

@RestController
public class GunController {
    private final AtomicLong counter = new AtomicLong();

    @RequestMapping(value = "/gun", method = RequestMethod.GET)
    public GunModel printGun(@RequestParam(value = "name") String name
                             , @RequestParam(value = "type") String type
                             , @RequestParam(value = "price") double price
                             , @RequestParam(value = "supplier") String supplier) {
        return new GunModel(counter.incrementAndGet(), name, type, price, supplier);
    }
}
