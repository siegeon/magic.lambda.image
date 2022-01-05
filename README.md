
# Creating images and QR code using Hyperlambda

Image manipulation library for Magic, allowing you to do basic manipulation of images, in addition to generating
QR codes. More specifically this project contains the following slot.

* __[qr.generate]__ - Generate a QR code with the specified payload

## Generating a QR code

You can use the **[qr.generate]** slot to create a QR code. This slot returns the QR code as a `MemoryStream`, which
allows you to return its output directly over the HTTP response object, which again will persist the QR code
back as the response to the caller if you're in a web project of some sort using Magic. The slot takes two arguments.

* Value of node - Mandatory string to become the content of the generated QR code
* __[size]__ - Optional argument declaring the size of your QR code

Below is an example of usage

```
qr.generate:"https://anarq.org"
   size:8
```

After execution, the above invocation slot will contain a `MemoryStream` encapsulating your underlaying code.
Below is an example QR code generated by the library.

![QR Code](https://servergardens.files.wordpress.com/2020/10/generate-qr.png)

## Project website

The source code for this repository can be found at [github.com/polterguy/magic.lambda.image](https://github.com/polterguy/magic.lambda.image), and you can provide feedback, provide bug reports, etc at the same place.

## Quality gates

- ![Build status](https://github.com/polterguy/magic.lambda.image/actions/workflows/build.yaml/badge.svg)
- [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=alert_status)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=bugs)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=code_smells)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=coverage)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=ncloc)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=security_rating)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=sqale_index)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
- [![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=polterguy_magic.lambda.image&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=polterguy_magic.lambda.image)
