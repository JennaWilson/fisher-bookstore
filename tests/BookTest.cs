using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests 
{
    public class BookTest
    {
        [Fact]
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                ID = 1,
                Title = "Doman Driven Design",
                Author = new Author()
                {
                    ID = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };
            //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);
            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDataString();

            Assert.Equal(expectedPublicationDate, actualPublicationDate);

            //Add 
            var newTitle = "Once Upon A Time"; 
            book.AddTitle(newTitle);

            //Update
            var TitleUpdate = "Once Upon A Time Limited Edition";
            book.UpdateTitle(newTitle);
                }
            }

        }
    