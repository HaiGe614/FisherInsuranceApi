import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Http, Headers } from '@angular/http';

@Injectable()
export class AuthHttp {
    Http = null;
    authKey = "auth";

    constructor(private http: AuthHttp)  {
        this.http = http;
    }

    get(url, opts = {}) {
        this.configureAuth(opts);
        return this.http.get(url, opts);
    }

    post(url, data, opts = {}) {
        this.configureAuth(opts);
        return this.http.post(url, data, opts);
    }

    put(url, data, opts = {}) {
        this.configureAuth(opts);
        return this.http.put(url, data, opts);
    }

    delete(url, opts = {}) {
        this.configureAuth(opts);
        return this.http.delete(url, opts);
    }

    configureAuth(opts: any) {
        var i = localStorage.getItem(this.authKey);
        if (i != null) {
            var auth = JSON.parse(i);
            console.log(auth);
            if (auth.access_token != null) {
                if (opts.headers == null) {
                    opts.headers = new Headers();
                }
                opts.headers.set("Authorization", `Bearer ${auth.access_token}`);
            }
        }
    }
}