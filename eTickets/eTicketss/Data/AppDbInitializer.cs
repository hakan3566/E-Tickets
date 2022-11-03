using eTickets.Data;
using eTickets.Models;
using eTicketss.Data.Static;
using eTicketss.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketss.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema,Actors,Producers,Movies,Actors&Movies
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()

                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Interno_di_un_sala_da_cinema.JPG/300px-Interno_di_un_sala_da_cinema.JPG",
                            Description = "This is the description of the first cinema."

                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Interno_di_un_sala_da_cinema.JPG/300px-Interno_di_un_sala_da_cinema.JPG",
                            Description = "This is the description of the second cinema."
                        },
                         new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Interno_di_un_sala_da_cinema.JPG/300px-Interno_di_un_sala_da_cinema.JPG",
                            Description = "This is the description of the third cinema."

                        },
                        new Cinema()
                        {
                           Name = "Cinema 4",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Interno_di_un_sala_da_cinema.JPG/300px-Interno_di_un_sala_da_cinema.JPG",
                            Description = "This is the description of the fourth cinema."
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Interno_di_un_sala_da_cinema.JPG/300px-Interno_di_un_sala_da_cinema.JPG",
                            Description = "This is the description of the fifth cinema."
                        },
                    });
                    context.SaveChanges();
                    
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Brad Pitt",
                            Bio = "William Bradley Pitt (born December 18, 1963) is an American actor and film producer.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/220px-Brad_Pitt_2019_by_Glenn_Francis.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Jason Statham",
                            Bio = "Jason Statham ( born 26 July 1967) is an English actor.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Jason_Statham_2018.jpg/220px-Jason_Statham_2018.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Ben Affleck",
                            Bio = "Benjamin Géza Affleck (born August 15, 1972) is an American actor and filmmaker.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Ben_Affleck_by_Gage_Skidmore_3.jpg/220px-Ben_Affleck_by_Gage_Skidmore_3.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Rosamund Pike",
                            Bio = "Rosamund Mary Ellen Pike (born 1979)[a] is a British actress and narrator.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/MJK_10907_Rosamund_Pike_%28Berlinale_2018%29_%28cropped%29.jpg/220px-MJK_10907_Rosamund_Pike_%28Berlinale_2018%29_%28cropped%29.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Jennifer Lopez",
                            Bio = "Jennifer Lynn Affleck (born July 24, 1969), also known as J.Lo, is an American singer, actress.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/eb/210120-D-WD757-1975_%2850860511978%29_%28cropped%29.jpg/220px-210120-D-WD757-1975_%2850860511978%29_%28cropped%29.jpg"

                        }

                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName="Ceán Chaffin",
                            Bio="Ceán Chaffin (born June 26, 1957) is an American film producer who has frequently collaborated with her husband, director David Fincher.",
                            ProfilePictureURL="https://images.mubicdn.net/images/cast_member/10214/cache-100886-1416353134/image-w856.jpg?size=120x"
                        },
                        new Producer()
                        {
                            FullName="Art Linson",
                            Bio="Art Linson (born 16 March 1942) is an American producer, screenwriter and author.",
                            ProfilePictureURL="https://m.media-amazon.com/images/M/MV5BMTI3NjM5MzM5M15BMl5BanBnXkFtZTcwMzQ1OTkxMw@@._V1_UY317_CR52,0,214,317_AL_.jpg"
                        },
                        new Producer()
                        {
                            FullName="Arnon Milchan",
                            Bio="Arnon Milchan ( December 6, 1944) is an Israeli businessman, film producer and spy.",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Arnon_Milchan_%28990040376210205171%29.jpg/220px-Arnon_Milchan_%28990040376210205171%29.jpg"
                        },
                        new Producer()
                        {
                            FullName="Joshua Donen",
                            Bio="Joshua Donen (born 1955)[1] is an American film producer.",
                            ProfilePictureURL="https://m.media-amazon.com/images/M/MV5BNzA4ZDdkMTYtZWViNS00OWNmLWEzZWQtM2UwZmQxOGNlM2U2XkEyXkFqcGdeQXVyMjYyMzE5OTk@._V1_.jpg"
                        },
                        new Producer()
                        {
                            FullName="Benny Medina",
                            Bio="Benny Medina (born January 24, 1958) is an American record executive, talent manager, and television producer.",
                            ProfilePictureURL="https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/BennyMedinaHWOFMay2013.jpg/220px-BennyMedinaHWOFMay2013.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name="Allied",
                            Description="Allied is a 2016 romantic war thriller film directed by Robert Zemeckis and written by Steven Knight.\"",
                            Price=40.50,
                            ImageUrl="https://upload.wikimedia.org/wikipedia/tr/thumb/9/9a/M%C3%BCttefik_film_afi%C5%9Fi.jpg/220px-M%C3%BCttefik_film_afi%C5%9Fi.jpg",
                            StartDate=DateTime.Now.AddDays(-10),
                            EndDate=DateTime.Now.AddDays(-2),  
                            CinemaId=1,
                            ProducerId=3,
                            MovieCategory=Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name="Fiht Club",
                            Description="Fight Club is a 1999 American film directed by David Fincher and starring Brad Pitt, Edward Norton, and Helena Bonham Carter.",
                            Price=40.50,
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg",
                            StartDate=DateTime.Now.AddDays(3),
                            EndDate=DateTime.Now.AddDays(20),
                            CinemaId=1,
                            ProducerId=2,
                            MovieCategory=Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name="Death Race",
                            Description="Death Race is a 2008 dystopian action thriller film written and directed by Paul W. S. Anderson. It stars Jason Statham, Tyrese Gibson, Ian McShane, and Joan Allen.",
                            Price=140.50,
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/d2/Death_race_poster.jpg",
                            StartDate=DateTime.Now.AddDays(2),
                            EndDate=DateTime.Now.AddDays(12),
                            CinemaId=2,
                            ProducerId=3,
                            MovieCategory=Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name="Gone Girl",
                            Description="Gone Girl is a 2014 American psychological thriller film directed by David Fincher and written by Gillian Flynn, based on her 2012 novel of the same name.",
                            Price=40.50,
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/0/05/Gone_Girl_Poster.jpg",
                            StartDate=DateTime.Now.AddDays(5),
                            EndDate=DateTime.Now.AddDays(14),
                            CinemaId=3,
                            ProducerId=4,
                            MovieCategory=Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name="Halftime",
                            Description="Its story follows the career of Jennifer Lopez, with a heavy focus on her performance at the Super Bowl LIV halftime show and her film Hustlers (2019).",
                            Price=40.50,
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/thumb/e/e0/Halftime_Poster.jpg/220px-Halftime_Poster.jpg",
                            StartDate=DateTime.Now.AddDays(-5),
                            EndDate=DateTime.Now.AddDays(5),
                            CinemaId=4,
                            ProducerId=4,
                            MovieCategory=Enums.MovieCategory.Documentary
                        }
                        
                    });
                    context.SaveChanges();
                }

                //Actors&Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId=1,
                            MovieId=1
                        },
                        new Actor_Movie()
                        {
                            ActorId=2,
                            MovieId=2
                        },
                        new Actor_Movie()
                        {
                            ActorId=3,
                            MovieId=3
                        },
                        new Actor_Movie()
                        {
                            ActorId=4,
                            MovieId=4
                        },
                        new Actor_Movie()
                        {
                            ActorId=5,
                            MovieId=5
                        }
                    });
                    context.SaveChanges();
                }
            }


        }

        public static async Task SeedUsersAndRoleAsync(IApplicationBuilder appBuilder)
        {
            using (var serviceScope= appBuilder.ApplicationServices.CreateScope())
            {
                //Roles 
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed=true

                    };
                    await userManager.CreateAsync(newAdminUser,"Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser,UserRoles.Admin);
                }

                
                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true

                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
