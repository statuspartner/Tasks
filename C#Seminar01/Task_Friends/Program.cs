int count = 0;
int distance = 100;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 3;
int friend = 2;
int minDistance = 3;
int time;

while(distance > minDistance)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.Write("Собака перебежит от друга к другу ");
Console.Write(count);
Console.WriteLine(" раз(а), пока они не встретятся.");