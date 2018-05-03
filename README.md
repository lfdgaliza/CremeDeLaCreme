# CremeDeLaCreme

## Initial notes

It was my first project using Angular 4 and dotnet core 1.x

I made some decisions here that I wouldn't make again such as putting Angular and Dotnet in the same project. I would prefer to put in separated projects for many reasons:

1. Structure
    * I think that it was a mess to put everything together.
2. Separation of responsibility
3. Cost
    * I had to pay for a host for this project. If I would have separated I could put in some static server such as S3 (AWS) and make the few functionalities as lambda functions. The monthly cost would be very low in comparison.

I guess that as a developer this is such a common thing... Seeing something that you made in the past and thinking that it could be better. It's a matter of evolution, isn't it? =)

> Note: It isn't online anymore, so you can only see the code, unfortunately :(

## Structure
* Locations
    * Angular code: src/app
    * .Net Core code: src/api
* src/api/Domain/Repositories/EntityTypeConfiguration
    * It was a file that I could get on Microsoft's forum about dotnet core because it was not possible at that moment to have Fluent Mappings in separate files (which you can find in the Maps folder)
* app/landing-page
    * Since that was a landing page, I chose to put each section into a separate component in order to get a better maintenance.
* MimeKit
    * I had to use an external lib in order to send emails due to the lack of such a thing in dotnet core 1.x (for God's sake!)

## Conclusion
The life is easier now with dotnet core 2.x.