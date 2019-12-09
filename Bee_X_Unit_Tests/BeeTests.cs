using Un_Bee_Lieable_Proj.Bees;
using Xunit;

namespace Bee_X_Unit_Tests
{
    public class BeeTests
    {
        [Theory]
        [InlineData(-1, 100)]
        [InlineData(0, 100)]
        [InlineData(25, 75)]
        [InlineData(50, 50)]
        [InlineData(75, 25)]
        [InlineData(100, 0)]
        [InlineData(105, 100)]
        public void DroneDamage(int attackDamage, float expectedHealthAfter)
        {
            //Arrange
            var droneService = new Drone(); 

            //Act
            var sut = droneService.Damage(attackDamage);

            //Assert
            Assert.Equal(expectedHealthAfter, sut);

        } //IsItADrone

        [Theory]
        [InlineData(10,10,false)]
        [InlineData(25,25,false)]
        [InlineData(30,30,true)]
        public void DeadDrone(int attack1, int attack2, bool isDead)
        {
            //Arrange
            var droneService = new Drone(); 

            //Act
            var sut = droneService.Damage(attack1);
            sut = droneService.Damage(attack2);

            //Assert
            if(isDead)
            {
                Assert.True(droneService.isDead);
            }
            else
            {
                Assert.False(droneService.isDead);
            }
        }

        [Theory]
        [InlineData(-1, 100)]
        [InlineData(0, 100)]
        [InlineData(25, 75)]
        [InlineData(50, 50)]
        [InlineData(75, 25)]
        [InlineData(100, 0)]
        [InlineData(105, 100)]
        public void QueenDamage(int attackDamage, float expectedHealthAfter)
        {
            //Arrange
            var queenService = new Queen(); 

            //Act
            var sut = queenService.Damage(attackDamage);

            //Assert
            Assert.Equal(expectedHealthAfter, sut);

        } //QueenDamage

        [Theory]
        [InlineData(20,20,false)]
        [InlineData(35,35,false)]
        [InlineData(45,45,true)]
        public void DeadQueen(int attack1, int attack2, bool isDead)
        {
            //Arrange
            var queenService = new Queen(); 

            //Act
            var sut = queenService.Damage(attack1);
            sut = queenService.Damage(attack2);

            //Assert
            if(isDead)
            {
                Assert.True(queenService.isDead);
            }
            else
            {
                Assert.False(queenService.isDead);
            }
        }

        [Theory]
        [InlineData(-1, 100)]
        [InlineData(0, 100)]
        [InlineData(25, 75)]
        [InlineData(50, 50)]
        [InlineData(75, 25)]
        [InlineData(100, 0)]
        [InlineData(105, 100)]
        public void WorkerDamage(int attackDamage, float expectedHealthAfter)
        {
            //Arrange
            var workerService = new Worker(); 

            //Act
            var sut = workerService.Damage(attackDamage);

            //Assert
            Assert.Equal(expectedHealthAfter, sut);

        } //WorkerDamage

        [Theory]
        [InlineData(5,5,false)]
        [InlineData(15,15,false)]
        [InlineData(45,45,true)]
        public void DeadWorker(int attack1, int attack2, bool isDead)
        {
            //Arrange
            var workerService = new Worker(); 

            //Act
            var sut = workerService.Damage(attack1);
            sut = workerService.Damage(attack2);

            //Assert
            if(isDead)
            {
                Assert.True(workerService.isDead);
            }
            else
            {
                Assert.False(workerService.isDead);
            }
        }

        [Fact]
        public void NoExtraDamage()
        {
            //Arrange
            var workerService = new Worker();

            //Act
            var sut = workerService.Damage(75);
            sut = workerService.Damage(10);

            //Assert
            Assert.Equal(25, sut);
            Assert.True(workerService.isDead);
        }
    }
}