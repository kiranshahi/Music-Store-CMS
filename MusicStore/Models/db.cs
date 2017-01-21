using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class db
    {
        public List<Genre> GetGenreData()
        {
            var genres = new List<Genre>
            {
                new Genre{ GenreId = 1, GenreName = "Rock", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                new Genre {GenreId = 2, GenreName = "Pop", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                new Genre {GenreId = 3, GenreName = "Jazz", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                new Genre {GenreId = 4, GenreName = "Metal", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                new Genre {GenreId = 4, GenreName = "Disco", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Genre {GenreId = 5, GenreName = "Blues", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."}
            };
            return genres;
        }

        public List<Album> GetAlbumsData()
        {
            var albums = new List<Album>
            {
                new Album {AlbumId = 1, AlbumName = "Album 1", ArtistId = 1, GenreId = 1, Image = "/images/album/1.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Album {AlbumId = 2, AlbumName = "Album 2", ArtistId = 1, GenreId = 2, Image = "/images/album/2.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Album {AlbumId = 3, AlbumName = "Album 3", ArtistId = 1, GenreId = 3, Image = "/images/album/3.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Album {AlbumId = 4, AlbumName = "Album 4", ArtistId = 1, GenreId = 4, Image = "/images/album/1.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Album {AlbumId = 5, AlbumName = "Album 5", ArtistId = 1, GenreId = 5, Image = "/images/album/1.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Album {AlbumId = 6, AlbumName = "Album 6", ArtistId = 1, GenreId = 6, Image = "/images/album/1.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                new Album {AlbumId = 7, AlbumName = "Album 7", ArtistId = 1, GenreId = 7, Image = "/images/album/1.jpg", Price = 1.09, Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod\r\ntempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\nquis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo\r\nconsequat. Duis aute irure dolor in reprehenderit in voluptate velit esse\r\ncillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non\r\nproident, sunt in culpa qui officia deserunt mollit anim id est laborum."}
            };
            return albums;
        }

        public List<Artist> GetArtistsDetails()
        {
            var artists = new List<Artist>
            {
                new Artist {ArtistId = 1, Name = "Drake"},
                new Artist {ArtistId = 2, Name = "Twenty One Pilots"},
                new Artist {ArtistId = 3, Name = "The Chainsmokers"},
                new Artist {ArtistId = 4, Name = "Sia"},
                new Artist {ArtistId = 5, Name = "The Weeknd"},
                new Artist {ArtistId = 6, Name = "Rihanna"},
                new Artist {ArtistId = 7, Name = "Desiigner"},
                new Artist {ArtistId = 8, Name = "Shawn Mendes"},
                new Artist {ArtistId = 9, Name = "Ariana Grande"},
                new Artist {ArtistId = 10, Name = "Calvin Harris"},
                new Artist {ArtistId = 11, Name = "D.R.A.M."},
                new Artist {ArtistId = 12, Name = "DJ Khaled"},
                new Artist {ArtistId = 13, Name = "X Ambassadors"},
                new Artist {ArtistId = 14, Name = "Adele"},
                new Artist {ArtistId = 15, Name = "Florida Georgia Line"},
                new Artist {ArtistId = 16, Name = "gnash"},
                new Artist {ArtistId = 17, Name = "DJ Snake"},
                new Artist {ArtistId = 18, Name = "Kiiara"},
                new Artist {ArtistId = 19, Name = "Hailee Steinfeld"},
                new Artist {ArtistId = 20, Name = "Charlie Puth"},
                new Artist {ArtistId = 21, Name = "Rae Sremmurd"},
                new Artist {ArtistId = 22, Name = "Tory Lanez"},
                new Artist {ArtistId = 23, Name = "Lil Uzi Vert"},
                new Artist {ArtistId = 24, Name = "Lukas Graham"},
                new Artist {ArtistId = 25, Name = "Future"},
                new Artist {ArtistId = 26, Name = "Alessia Cara"},
                new Artist {ArtistId = 27, Name = "J. Cole"},
                new Artist {ArtistId = 28, Name = "Rob $tone"},
                new Artist {ArtistId = 29, Name = "Coldplay"},
                new Artist {ArtistId = 30, Name = "Young M"},
                new Artist {ArtistId = 31, Name = "Martin Garrix"},
                new Artist {ArtistId = 32, Name = "Bruno Mars"},
                new Artist {ArtistId = 33, Name = "21 Savage"},
                new Artist {ArtistId = 34, Name = "Lil Wayne"},
                new Artist {ArtistId = 35, Name = "Zay Hilfigerrr"},
                new Artist {ArtistId = 36, Name = "Keith Urban"},
                new Artist {ArtistId = 37, Name = "Daya"},
                new Artist {ArtistId = 38, Name = "P!nk"},
                new Artist {ArtistId = 39, Name = "Amine"},
                new Artist {ArtistId = 40, Name = "Maroon 5"},
                new Artist {ArtistId = 41, Name = "Kenny Chesney"},
                new Artist {ArtistId = 42, Name = "Flume"},
                new Artist {ArtistId = 43, Name = "Usher"},
                new Artist {ArtistId = 44, Name = "Young Thug"},
                new Artist {ArtistId = 45, Name = "Justin Bieber"},
                new Artist {ArtistId = 46, Name = "Kanye West"},
                new Artist {ArtistId = 47, Name = "Meghan Trainor"},
                new Artist {ArtistId = 48, Name = "Mike Posner"},
                new Artist {ArtistId = 49, Name = "DNCE"},
                new Artist {ArtistId = 50, Name = "Niall Horan"},
                new Artist {ArtistId = 51, Name = "Kent Jones"},
                new Artist {ArtistId = 52, Name = "Cole Swindell"},
                new Artist {ArtistId = 53, Name = "Jon Bellion"},
                new Artist {ArtistId = 54, Name = "Beyoncé"},
                new Artist {ArtistId = 55, Name = "Kelsea Ballerini"},
                new Artist {ArtistId = 56, Name = "Jason Aldean"},
                new Artist {ArtistId = 57, Name = "Lil Yachty"},
                new Artist {ArtistId = 58, Name = "Miranda Lambert"},
                new Artist {ArtistId = 59, Name = "PartyNextDoor"},
                new Artist {ArtistId = 60, Name = "Dierks Bentley"},
                new Artist {ArtistId = 61, Name = "Carrie Underwood"},
                new Artist {ArtistId = 62, Name = "Chance the Rapper"},
                new Artist {ArtistId = 63, Name = "ScHoolboy Q"},
                new Artist {ArtistId = 64, Name = "Luke Bryan"},
                new Artist {ArtistId = 65, Name = "Pentatonix"},
                new Artist {ArtistId = 66, Name = "Lady Gaga"},
                new Artist {ArtistId = 67, Name = "Sam Hunt"},
                new Artist {ArtistId = 68, Name = "DJ Esco"},
                new Artist {ArtistId = 69, Name = "Brett Young"},
                new Artist {ArtistId = 70, Name = "John Legend"},
                new Artist {ArtistId = 71, Name = "Migos"},
                new Artist {ArtistId = 72, Name = "Billy Currington"},
                new Artist {ArtistId = 73, Name = "Katy Perry"},
                new Artist {ArtistId = 74, Name = "Blake Shelton"},
                new Artist {ArtistId = 75, Name = "Big Sean"},
                new Artist {ArtistId = 76, Name = "Britney Spears"},
                new Artist {ArtistId = 77, Name = "Dan + Shay"},
                new Artist {ArtistId = 78, Name = "Future"},
                new Artist {ArtistId = 79, Name = "French Montana"},
                new Artist {ArtistId = 80, Name = "Wale"},
                new Artist {ArtistId = 81, Name = "Brett Eldredge"},
                new Artist {ArtistId = 82, Name = "Old Dominion"},
                new Artist {ArtistId = 83, Name = "Kungs"},
                new Artist {ArtistId = 84, Name = "Mariah Carey"},
                new Artist {ArtistId = 85, Name = "Selena Gomez"},
                new Artist {ArtistId = 86, Name = "Jake Owen"},
                new Artist {ArtistId = 87, Name = "Kehlani"},
                new Artist {ArtistId = 88, Name = "Eric Church"},
                new Artist {ArtistId = 89, Name = "James Bay"},
                new Artist {ArtistId = 90, Name = "Marc E. Bassy"},
                new Artist {ArtistId = 91, Name = "Machine Gun Kelly x Camila Cabello"},
                new Artist {ArtistId = 92, Name = "Zara Larsson"},
                new Artist {ArtistId = 93, Name = "Fitz & the Tantrums"},
                new Artist {ArtistId = 94, Name = "Little Big Town"},
                new Artist {ArtistId = 95, Name = "Jon Pardi"},
                new Artist {ArtistId = 96, Name = "Nick Jonas"},
                new Artist {ArtistId = 97, Name = "Dae Dae"}
            };
            return artists;
        }
    }
}