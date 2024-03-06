public class UserRepository {
    public List<User> GetAll() 
        => new ()
        {
            new User(11,"John Doe",new DateOnly(1999,10,05))
        };
}
