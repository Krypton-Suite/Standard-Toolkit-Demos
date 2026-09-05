namespace KryptonBindingNavigatorExample;

/// <summary>
/// PersonDetail class used as a data model for the KryptonBindingNavigator demo.
/// This class provides detailed person information for demonstrating data binding.
/// </summary>
public class PersonDetail
{
    public int Id
    {
        get;
        set;
    }

    public string FirstName
    {
        get;
        set;
    } = string.Empty;

    public string LastName
    {
        get;
        set;
    } = string.Empty;

    public string Email
    {
        get;
        set;
    } = string.Empty;

    public int Age
    {
        get;
        set;
    }
}