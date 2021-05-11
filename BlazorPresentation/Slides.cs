using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPresentation
{
    public static class Slides
    {
        public static event EventHandler SlideChanged;

        private static int sharedSlide = 0;
        public static int SharedSlide
        {
            get => sharedSlide;
            set
            {
                if (sharedSlide != value)
                {
                    sharedSlide = value;
                    SlideChanged?.Invoke(null, new EventArgs());
                }
            }
        }

        public static List<SlideData> SharedSlides = new List<SlideData>
        {
        new SlideData
        {
            Title="Server Side Blazor - The web from a different angle",
            Body=(MarkupString)@"<p>Presented by James Johnston<br>
<b>Software Engineer</b></p>

<p><i>Support from Sami Lamti</i></p>",
            Images=new List<string>
                {
                "../../images/jj.jpg",
                "../../images/sl.jpg"
            }
        },
        new SlideData
        {
            Title="A short history lesson",
            Body=(MarkupString)@"Some of the current framework options",
            Images=new List<string>
            {
                "../../images/JavaScript-Frameworks.png",

            },
            Script=(MarkupString)"In this day and age, there are more ways to build for the web than you can count. You have multiple different approaches, languages and stacks."
        },
        new SlideData
        {
            Title="A short history lesson",
            Body=(MarkupString)@"A PHP developer in his natural habitat",
            Images=new List<string>
            {

                "../../images/Stone-Age-in-Africa-1024x512.jpg"
            },
            Script=(MarkupString)"Until relatively recently, the prefered approach when any kind of dynamic content was involved, was to render the front end on the back end, using technologies like PHP, classic ASP and ASP.NET."
        },
        new SlideData
        {
            Title ="A short history lesson",
            Body=(MarkupString)"As sad as it is to admit - Microsoft invented the modern web",
            Images=new List<string>{ "../../images/OWA-OA-Comparison-1.png" },
            Script=(MarkupString)"These evolved over time and added client side features, allowing the clients to be more responsive and to change data on the page live rather than forcing a reload. Enter AJAX - asyncronous JavaScript and XML."
        },
        new SlideData
        {
            Title = "Blazor's big selling point",
            Body=(MarkupString)"a c# developer, moving to javascript, 2005, colourized",
            Images=new List<string>{ "../../images/man_computer_depressed.jpg" },
            Script=(MarkupString)"This move from exposing the UI from the backend in server languages like C# to exposing in the front end with JavaScript meant that a large number of developers had to leave their comfort zones in order to participate."

        },
        new SlideData
        {
            Title="Blazor's big selling point",
            Body=(MarkupString)"javascript ===== bad;",
            Images = new List<string>
            {
                "../../images/bad-code.png"
            },
            Script=(MarkupString)"It's also not hard to argue that JavaScript isn't ideal for larger projects. It suffers from a lack of type safety and thus coersion hurdles. It can behave different in different browsers (less of an issue these days) and even has fundamental issues with basic maths. Its the best programming language we have in the browser mostly due to it being the only language we have in the browser. This is why TypeScript was invented."

        },
        new SlideData
        {
            Title="Blazor's big selling point",
            Body=(MarkupString)"WASM is good javascript. Because you dont use javascript.",
            Images=new List<string>{ "../../images/wasm-ferris.png" },
            Script=(MarkupString)"That was true until WASM - Web Assembly - Mozilla's genius simplification of JavaScript down to the bare essentials - but amazingly optimised - the idea being it can be used a compile target - it's not supposed to be used by devs - but compiler tools."
        },
        new SlideData
        {
            Title="Blazor's big selling point",
            Body=(MarkupString)"WASM is good javascript. Because you can use C#",
            Images=new List<string>{ "../../images/Blazor.png" },
            Script=(MarkupString)@"<p>This enabled Microsoft and Xamarin to produce Blazor - a new take on the client - powered by a complete version of .NET (Mono) running on WASM. This means your client code is any .NET supported language such as C# - allowing for enterprise standards in front end code.</p>

<p>You still need to follow the same pattern, with the front end accessing the back end via APIs etc - but if your backend is also C#, this allows a lot of code reuse - especially around models and the like.</p>"
        },
        new SlideData
        {
            Title="Blazor's big selling point",
            Body=(MarkupString)"Clever. Not useful",
            Images=new List<string>{ "../../images/image-377-news.jpg" },
            Script=(MarkupString)"This is an amazing technical achievement. It's also not that useful. At this point in time, JavaScript is THE defacto standard for front end and thus moving away from it has a huge number of downsides."
        },
        new SlideData
        {
            Title="Blazors twin, Blazor",
            Body=(MarkupString)"The same. But different",
            Images=new List<string>{ "../../images/twins_twins.jpg" },
            Script=(MarkupString)"Blazor actually comes in two flavours"
        },
        new SlideData
        {
            Title="Blazors twin, Blazor",
            Body=(MarkupString)"The samer. But differenter",
            Images=new List<string>{ "../../images/maxresdefault.jpg" },
            Script=(MarkupString)"client side and server side. Server side is where things get very interesting. It's code compatible with client side but works very differently, more like the frameworks of old - it runs entirely on the server, even \"client\" code. The difference from the frameworks of yesteryear is how this client code pushes the ui to the client - rather than full page refreshes and the like, the server manages a local DOM and sends deltas of this DOM to the client using SignalR. This means there is almost no load on the front end, the experience is very similar to a javascript framework - but most interestingly - the client never sees the client code. This opens up a number of options that let you think about things differently."
        },
        new SlideData
        {
            Title="So where do we live?",
            Body=(MarkupString)"Back end and front end is still a thing...",
            Images=new List<string>{ "../../images/back-front-end.png" },
            Script=(MarkupString)"When moving code from a Blazor client side project to a server side project - the first thing you will probably notice is how fast API calls are - because realistically, they arent going across the web - both the front end and backend are running in the same place - you have direct access to the API server."
        },
        new SlideData
        {
            Title="So where do we live?",
            Body=(MarkupString)"Not quite THIS direct access",
            Images=new List<string>{ "../../images/harddrive.jpg" },
            Script=(MarkupString)"But if this is true - your front end code has the same access as the back end. You can write front end code to directly access your SQL servers, your file system etc. You probably shouldn't but you can."
        },
        new SlideData
        {
            Title="So where do we live?",
            Body=(MarkupString)"Old but new",
            Images=new List<string>{ "../../images/oldnew.jpg" },
            Script=(MarkupString)"Blazer server side lives in this beautiful middleground between the old and the new. The fluent and responsive UI of js frameworks, but the power and control of the old serverside frameworks. It's not perfect, but its close - and its constantly improving."
        },
        new SlideData
        {
            Title="What does that mean?",
            Body=(MarkupString)"<p>Front end paradigms that are new and interesting from an SPA point of view:</p>",

            Script=(MarkupString)"Lets think about front end paradigms that are new and interesting from an SPA point of view:"
        },
        new SlideData
        {
            Title="What does that mean?",
            Body=(MarkupString)@"<p>Front end paradigms that are new and interesting from an SPA point of view:</p>
<ul>
<li>Secrets are secret</li>
</ul>",

            Script=(MarkupString)"Secrets are secret: Private keys can be consumed in the front end - and remain private."
        },
        new SlideData
        {
            Title="What does that mean?",
            Body=(MarkupString)@"<p>Front end paradigms that are new and interesting from an SPA point of view:</p>
<ul>
<li>Secrets are secret</li>
<li>If its on the server, its in the front end</li>
</ul>",

            Script=(MarkupString)"If its on the server, its in the front end: The filesystem, other machines on the LAN, ports behind the firewall - the lot - its all accessible."
        }
        ,
        new SlideData
        {
            Title="What does that mean?",
            Body=(MarkupString)@"<p>Front end paradigms that are new and interesting from an SPA point of view:</p>
<ul>
<li>Secrets are secret</li>
<li>If its on the server, its in the front end</li>
<li>You control the performance</li>
</ul>",

            Script=(MarkupString)"You control the performance: While you are running every users front end and thus its a heavier load, you get to define the resources - you dont need to worry if an end user has enough cpu to render your massive list in a reasonable time etc - the users browser is just a thin client."
        }        ,
        new SlideData
        {
            Title="What does that mean?",
            Body=(MarkupString)@"<p>Front end paradigms that are new and interesting from an SPA point of view:</p>
<ul>
<li>Secrets are secret</li>
<li>If its on the server, its in the front end</li>
<li>You control the performance</li>
<li>Its possible to share between sessions/clients</li>
</ul>",

            Script=(MarkupString)"Its possible to share between sessions/clients: Caching becomes almost irrelevant when you can have data in a static global."
        },
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"No, unless it was okay before",
            Images=new List<string>{ "../../images/history.jpg" },
            Script=(MarkupString)"tl;dr - probably not. That said, if it was okay (and secure) in things like asp.net webforms - its still ok."
        },
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"You might not need an API but your customers probably do.",
            Images=new List<string>{ "../../images/swagger.png" },
            Script=(MarkupString)"Firstly, the front end doesn't need an API anymore - but you probably still do. Often the API is consumed by more than the website. That alone is a reason to not just tear out the API and put all the code in the front end, but you dont really want to manage two versions of the same code."
        }
        ,
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"Mediatr makes this easy. I recommend it.",
            Images=new List<string>{ "../../images/mediatr.png" },
            Script=(MarkupString)"If youve been a responsible developer and your API Controllers are very thin via a service or even better, by using the mediator pattern (with something like Mediatr) you have a great option; simply call the same code that the API would. This alone can give your app a massive boost. No HTTP requests are required, translation too and from JSON arent required, generally it is a thinner path."
        } ,
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"Empty controller is empty.",
            Images=new List<string>{ "../../images/emptycontroller.png" },
            Script=(MarkupString)"Once this is in place, you then have a decision to make: API controllers/methods which are entirely there to service the front end - can they be removed. The smaller the footprint of an API, the smaller the attack vector."
        }
         ,
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"Are you pondering what I am pondering?",
            Images=new List<string>{ "../../images/pinky.jpg" },
            Script=(MarkupString)"Once you are in the land of having a service that provides more than the API things get even more interesting. Your functions no longer need to be serializable. Nor do they need to be a\"reasonable size\"."
        },
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"statics CAN be a good thing.",
            Images=new List<string>{ "../../images/staticfetch.png" },
            Script=(MarkupString)"Lets look at an example. You have an online store. Your fetch products call can return images as images just as a field withing the model if that makes sense. You can fetch the entire product catalog in one fetch - if you need to; something static like this can ... be static."
        },
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"statics CAN be a good thing.",
            Images=new List<string>{ "../../images/staticfetch.png" },
            Script=(MarkupString)"If user a) has viewed the store, the data is already available. The view can still be paginated if that gives a better user experience, but you get the ability to VERY quickly use Linq queries; resort the data, apply filters etc - at lightening speed - theres no API call and theres no DB hit."
        }
        ,
        new SlideData
        {
            Title="Do I really want to do that sort of thing in client code?",
            Body=(MarkupString)"events? in the front end? across sessions?",
            Images=new List<string>{ "../../images/events.png" },
            Script=(MarkupString)"If you want to get very tricksy, there are some amazing options open. Lets say this store has a list of recently purchased items. Usually this would either be set on a schedule, once on page load or polled. With everything in the same domain, this could be completely event driven - it doesnt even need to be tied to the database."
        }
        ,
        new SlideData
        {
            Title="Things to consider",
            Body=(MarkupString)"Why'd you have to go and make things so complicated?",
            Images=new List<string>{ "../../images/complicated.jpg" },
            Script=(MarkupString)"Now, if youre like me, this is sounds very whizzy. That said, its not quite as simple as that."
        }
        ,
        new SlideData
        {
            Title="Things to consider",
            Body=(MarkupString)"The cloud, yesterday.",
            Images=new List<string>{ "../../images/servers.jpg" },
            Script=(MarkupString)"Everything in the previous section can be true - everything being in the same domain, on the same server. But this assumes only one server. If you have a larger site, there is a good chance you are using a scale out pattern - spinning up new servers when load requires - and maybe even spinning down ALL servers at times of zero traffic. "
        }  ,
        new SlideData
        {
            Title="Things to consider",
            Body=(MarkupString)"Gotta weigh it up.",
            Images=new List<string>{ "../../images/weighup.jpg" },
            Script=(MarkupString)"That means while sessions can share static variables, not every session can share the SAME session variable. With the last example we gave, the list of purchased items - this means if user A is on server 1 and buys something, then user B who is on server 2 will not receive the event. In some scenarios this is acceptable, but many it is not."
        }  ,
        new SlideData
        {
            Title="Things to consider",
            Body=(MarkupString)"Who doesn't love a good workaround",
            Images=new List<string>{ "../../images/workaround.jpg" },
            Script=(MarkupString)"There are work arounds for this. Azure webapps for instance has a local folder - thats actually shared across all instances. This can be watched for changes."
        },
        new SlideData
        {
            Title="Things to consider",
            Body=(MarkupString)"Google image search is a treasure",
            Images=new List<string>{ "../../images/polling.jpg" },
            Script=(MarkupString)"Even if you have to resort to polling the db, this can be done at the server level rather than the session level. This sort of thing goes a long way to offsetting the extra load of hosting - if you have 500 users spread across 5 servers, what would have been 500 API calls before (which likely would have been cached to some extent) you now just have 5 db calls."
        },
        new SlideData
        {
            Title="Things to consider",
            Body=(MarkupString)"Blazor is magic, but not work on IE3 magic.",
            Images=new List<string>{ "../../images/internetexplorer.png" },
            Script=(MarkupString)"A more fundamental concern is browsers without javascript or networks without support for SignalR. In those scenarios, Blazor Serverside just doesnt work."
        }
        ,
        new SlideData
        {
            Title="Security just got a whole lot easier",
            Body=(MarkupString)"Its more secure than this!",
            Images=new List<string>{ "../../images/vault.png" },
            Script=(MarkupString)"Beyond reducing what you expose to the wider world, Blazor Server Side flips the security problem on its head when compared with JS frameworks. "
        }
        ,
        new SlideData
        {
            Title="Security just got a whole lot easier",
            Body=(MarkupString)"This image was too random to not include.",
            Images=new List<string>{ "../../images/parrots.jpg" },
            Script=(MarkupString)"As we all know, any code within JS is public. Its run on the client so must be sent to the client. This means you have no ability to hide. Private keys arent private so just arent an option. "
        } ,
        new SlideData
        {
            Title="Security just got a whole lot easier",
            Body=(MarkupString)"The problem. It is solved.",
            Images=new List<string>{ "../../images/problemsolved.png" },
            Script=(MarkupString)"Obviously this is already a solved problem, but in this world, client code IS private. Private keys ARE private. "
        },
        new SlideData
        {
            Title="Security just got a whole lot easier",
            Body=(MarkupString)"This becomes trivial",
            Images=new List<string>{ "../../images/twitter.jpg" },
            Script=(MarkupString)"How does this help? Well, you need the client to go hit twitter with your dev API key? Thats totally fine. Generally, it makes security somewhat more brainless. Its so difficult for secrets to leak you almost dont need to consider it."
        }

        ,
        new SlideData
        {
            Title="With great power comes great responsibility",
            Body=(MarkupString)"Sorry Uncle Ben.",
            Images=new List<string>{ "../../images/spiderman.jpg" },
            Script=(MarkupString)"With the backend/js front end paradigm you are forced to have a minimal level of seperation between UI and business logic. "
        },
        new SlideData
        {
            Title="With great power comes great responsibility",
            Body=(MarkupString)"Sometimes you have to think for yourself.",
            Images=new List<string>{ "../../images/responsable.jpg" },
            Script=(MarkupString)"When dealing with Blazor Server Side, this is no longer enforced. If you so desire, you can have all of you business logic, all db access, all remote API calls - directly in the UI layer. You shouldn't, but you can. Because of this, developers need to be responsible."
        }
,
        new SlideData
        {
            Title="This is a lot to take in. What am I learning here?",
            Body=(MarkupString)"Personally, I say seven.",
            Images=new List<string>{ "../../images/angles.jpg" },
            Script=(MarkupString)"Blazor serverside requires you to think about your website from two different angles. These are not new angles, but never before did you really have to consider them at the same time."
        },
        new SlideData
        {
            Title="This is a lot to take in. What am I learning here?",
            Body=(MarkupString)"Personally, I say seven.",
            Images=new List<string>{ "../../images/architect.jpg" },
            Script=(MarkupString)"Overall, you think about your front end the same way you'd think about a webforms project - or even an API - whilst still considering the front end. Blazors front end is VERY opinionated about how you do things, but with that comes very simple code for doing crazy dynamic things. This coupled with the power that being server side gives you opens up some amazing options if you spend a bit more time thinking about how to architect."
        }
        ,
        new SlideData
        {
            Title="The big reveal",
            Body=(MarkupString)"Hold on, it gets a bit meta here",
            Images=new List<string>{ "../../images/deadpool.jpg" },
            Script=(MarkupString)"So time to get a little meta. This talk sounds fairly theoretical, but in an attempt to give examples, I built a blazor app that uses these theories."
        }

        ,
        new SlideData
        {
            Title="The big reveal",
            Body=(MarkupString)"Youre looking at it",
            Images=new List<string>{ "../../images/meta.png" },
            Script=(MarkupString)"Youre looking at it. This presentation is a Blazor server side app. You are viewing the slides in Edge. I'm using Chrome on another desktop to control the slides and read the script. Completely seperate session, driven entirely by shared variables and events. Some of the examples I've shown have been screenshots of this very app."
        }
        ,
        new SlideData
        {
            Title="The big reveal",
            Body=(MarkupString)"Android > iPhone... fight me. WindowsPhone was still best.",
            Images=new List<string>{ "../../images/oneplus.jpg" },
            Script=(MarkupString)"If this was running on a real server and not my desktop, I could be running the slide controller page on my phone and it not even need to be on the same network"
        }
         ,
        new SlideData
        {
            Title="The big reveal",
            Body=(MarkupString)"Android > iPhone... fight me. WindowsPhone was still best.",
            Images=new List<string>{ "../../images/oneplus.jpg" },
            Script=(MarkupString)"If this was running on a real server and not my desktop, I could be running the slide controller page on my phone and it not even need to be on the same network"
        }
                 ,
        new SlideData
        {
            Title="What next?",
            Body=(MarkupString)@"Additional resources: <br> 
<a href='https://www.youtube.com/watch?v=xr56fmgLl74&list=PL4WEkbdagHIR0RBe_P4bai64UDqZEbQap'>Build your first Blazor App</a><br>
<a href='https://discord.gg/vjZ8NmdqRb'>blazor discord</a> <br/>
<a href='https://chrissainty.com/'>Chris Saint's blog, the Jon Skeet of Blazor</a>",

            Images=new List<string>{ "../../images/youtube.png","../../images/discord.png","../../images/sainty.png" },
            Script=(MarkupString)"There are a number of resources I can recommend. Firstly is a fantastic youtube series to get you up and running with blazor, secondly is the discord server for blazor which is amazing and im not biased since i set it up, lastly is chris saintys blog - chris sainty is the closest thing the blazor world has to Jon Skeet. If you have a problem, you could scour google for the answer, or just skip the middleman and go directly to his blog."
        }
         ,
        new SlideData
        {
            Title="What next?",
            Body=(MarkupString)"You dont want it right now... trust me.",
            Script=(MarkupString)"I will also tidy up the code for this and share it on github. The code for it right now is a bit of a mess as it was done in a hurry, but as a simple tool where you can share slides and control which slide others are looking without screen sharing its actually a useful tool in this remote world"
        }        ,
        new SlideData
        {
            Title="What next?",
            Body=(MarkupString)"OPINIONS!",
            Script=(MarkupString)"I honestly beleive Blazor - in both iterations are a great fit for Redgate - and honestly, in a lot of scenarios, possibly a better fit than react. All I ask is when you look at blazor, dont think of it as a c# transpiler - its so much more than that - and can solve tricky problems in ways you may not have considered before."
        }
        ,
        new SlideData
        {
            Title="What next?",
            Body=(MarkupString)"Interest?",
            Script=(MarkupString)"If there is enough interest in Blazor, maybe a slack channel would make sense - theres plenty to play with, for instance, one of my 10% fridays I ported a few of the honeycomb product toolkit components to blazor components."
        }
        ,
        new SlideData
        {
            Title="What next?",
            Body=(MarkupString)"Just slack me?",
            Images=new List<string>{ "../../images/callmemaybe.jpg" },
            Script=(MarkupString)"Either way, feel free to slack me or hunt me down on discord out of hours. I'm very passionate about blazor and talking shop out of work time is certainly no hardship"
        }

        ,
        new SlideData
        {
            Title="Thanks",
            Body=(MarkupString)"Thanks to Sami, Dan, Julia... AND YOU!",
            Images=new List<string>{ "../../images/sl.jpg" },
            Script=(MarkupString)"I want to say thankyou for turning up, and I want to say thanks to all those that helped me with this talk, such as Julia and Dan, but especially Sami who encouraged me to make this presentation IN BLAZOR."
        }


        };
    }

    public class SlideData
    {
        public string Title { get; set; }
        public MarkupString Body { get; set; }
        public List<string> Images { get; set; }
        public MarkupString Script { get; set; }
    }

    public class Dummy
    {
        private static List<Product> products = null;
        public static List<Product> Products
        {
            get
            {
                if (products==null)
                {
                    products = GetProducts();
                }

                return products;
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public Guid Id { get; set; }
        }

        public static List<Product> GetProducts()
        {
            return null;
        }
    }
}
