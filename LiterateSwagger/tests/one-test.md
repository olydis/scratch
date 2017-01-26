# My Test Example

Note: this was pulled right from a Fiddler request. 

## Requests

``` message (request)
PUT http://localhost:10000/testaccount1/containersc5d3e7c5509046d2aa3f8bb095593T?timeout=30 HTTP/1.1
x-ms-version: 2016-05-31
x-ms-blob-type: PageBlob
x-ms-blob-content-length: 1024
x-ms-date: Wed, 11 Jan 2017 09:16:29 GMT
Content-Length: 23

{
  "foo":"bizzzzz"
}
```


## Responses

``` message (response)
HTTP/1.1 400 Bad Request
Content-Type: text/html; charset=us-ascii
Server: Microsoft-HTTPAPI/2.0
Date: Wed, 11 Jan 2017 09:16:29 GMT
Connection: close
Content-Length: 324

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN""http://www.w3.org/TR/html4/strict.dtd">
<HTML><HEAD><TITLE>Bad Request</TITLE>
<META HTTP-EQUIV="Content-Type" Content="text/html; charset=us-ascii"></HEAD>
<BODY><h2>Bad Request - Invalid URL</h2>
<hr><p>HTTP Error 400. The request URL is invalid.</p>
</BODY></HTML>
```

# Notes:  
this test has preconditions. These must be applied first!

``` json (before)

```

``` json (after)

```

