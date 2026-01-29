using FluentAssertions;

namespace IAmAJavaScriptFan.Test.Unit;

public class SyntaxTest
{
    [Test]
    public void Operator_ShouldReturnTrue_WhenValueIsReferenceType_AndNotNull()
    {
        var myValue = "Please dont fire me";
        Assert(myValue ? true : false); // this is so wrong
    }
    
    [Test]
    public void Operator_ShouldReturnTrue_WhenValueIsValueType_AndNotNull()
    {
        int? myValue = 5;
        Assert(myValue ? true : false);
    }
    
    [Test]
    public void Operator_ShouldReturnFalse_WhenValueIsReferenceType_AndNull()
    {
        string? myValue = null;
        Assert(myValue ? false : true); // invert cuz we actually check for it being null which is 'false'
    }
    
    [Test]
    public void Operator_ShouldReturnFalse_WhenValueIsValueType_AndNull()
    {
        int? myValue = null;
        Assert(myValue ? false : true);
    }

    private static void Assert(bool value) => true.Should().Be(value);
}