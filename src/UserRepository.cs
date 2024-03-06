public class UserRepository {
    public List<User> GetAll() 
        => new ()
        {
            new User(23,"John Doe",new DateOnly(1975,11,12))
        };
}
