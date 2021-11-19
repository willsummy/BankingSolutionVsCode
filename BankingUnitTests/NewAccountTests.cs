using BankingDomain;
using Xunit;

namespace BankingUnitTests;

public class NewAccountTests
{

    [Fact]
    public void NewAccountsHaveCorrectBalance()
    {
        var account = new BankAccount();

        Assert.Equal(5000M, account.GetBalance());
    }
}