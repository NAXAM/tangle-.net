﻿namespace Tangle.Net.Tests.Entity
{
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  using Tangle.Net.Source.Entity;

  /// <summary>
  /// The transaction tests.
  /// </summary>
  [TestClass]
  public class TransactionTests
  {
    #region Public Methods and Operators

    /// <summary>
    /// The test transaction generation from trytes.
    /// </summary>
    [TestMethod]
    public void TestTransactionGenerationFromTrytes()
    {
      var transaction = Transaction.FromTrytes(GetTransactionTrytes());

      Assert.AreEqual("JBVVEWEPYNZ9KRHNUUTRENXXAVXT9MKAVPAUQ9SJNSIHDCPQM9LJHIZGXO9PIRWUUVBOXNCBE9XJGMOZF", transaction.Hash.Value);

      Assert.AreEqual(
        "GYPRVHBEZOOFXSHQBLCYW9ICTCISLHDBNMMVYD9JJHQMPQCTIQAQTJNNNJ9IDXLRCCOYOXYPCLR9PBEY9ORZIEPPDNTI9CQWYZUOTAVBXPSBOFEQAPFLWXSWUIUSJMSJIIIZ"
        + "WIKIRH9GCOEVZFKNXEVCUCIIWZQCQEUVRZOCMEL9AMGXJNMLJCIA9UWGRPPHCEOPTSVPKPPPCMQXYBHMSODTWUOABPKWFFFQJHCBVYXLHEWPD9YUDFTGNCYAKQKVEZYRBQRB"
        + "XIAUX9SVEDUKGMTWQIYXRGSWYRK9SRONVGTW9YGHSZRIXWGPCCUCDRMAXBPDFVHSRYWHGB9DQSQFQKSNICGPIPTRZINYRXQAFSWSEWIFRMSBMGTNYPRWFSOIIWWT9IDSELM9"
        + "JUOOWFNCCSHUSMGNROBFJX9JQ9XT9PKEGQYQAWAFPRVRRVQPUQBHLSNTEFCDKBWRCDX9EYOBB9KPMTLNNQLADBDLZPRVBCKVCYQEOLARJYAGTBFR9QLPKZBOYWZQOVKCVYRG"
        + "YI9ZEFIQRKYXLJBZJDBJDJVQZCGYQMROVHNDBLGNLQODPUXFNTADDVYNZJUVPGB9LVPJIYLAPBOEHPMRWUIAJXVQOEM9ROEYUOTNLXVVQEYRQWDTQGDLEYFIYNDPRAIXOZEB"
        + "CS9P99AZTQQLKEILEVXMSHBIDHLXKUOMMNFKPYHONKEYDCHMUNTTNRYVMMEYHPGASPZXASKRUPWQSHDMU9VPS99ZZ9SJJYFUJFFMFORBYDILBXCAVJDPDFHTTTIYOVGLRDYR"
        + "TKHXJORJVYRPTDH9ZCPZ9ZADXZFRSFPIQKWLBRNTWJHXTOAUOL9FVGTUMMPYGYICJDXMOESEVDJWLMCVTJLPIEKBE9JTHDQWV9MRMEWFLPWGJFLUXI9BXPSVWCMUWLZSEWHB"
        + "DZKXOLYNOZAPOYLQVZAQMOHGTTQEUAOVKVRRGAHNGPUEKHFVPVCOYSJAWHZU9DRROHBETBAFTATVAUGOEGCAYUXACLSSHHVYDHMDGJP9AUCLWLNTFEVGQGHQXSKEMVOVSKQE"
        + "EWHWZUDTYOBGCURRZSJZLFVQQAAYQO9TRLFFN9HTDQXBSPPJYXMNGLLBHOMNVXNOWEIDMJVCLLDFHBDONQJCJVLBLCSMDOUQCKKCQJMGTSTHBXPXAMLMSXRIPUBMBAWBFNLH"
        + "LUJTRJLDERLZFUBUSMF999XNHLEEXEENQJNOFFPNPQ9PQICHSATPLZVMVIWLRTKYPIXNFGYWOJSQDAXGFHKZPFLPXQEHCYEAGTIWIJEZTAVLNUMAFWGGLXMBNUQTOFCNLJTC"
        + "DMWVVZGVBSEBCPFSM99FLOIDTCLUGPSEDLOKZUAEVBLWNMODGZBWOVQT9DPFOTSKRABQAVOQ9RXWBMAKFYNDCZOJGTCIDMQSQQSODKDXTPFLNOKSIZEOY9HFUTLQRXQMEPGO"
        + "XQGLLPNSXAUCYPGZMNWMQWSWCKAQYKXJTWINSGPPZG9HLDLEAWUWEVCTVRCBDFOXKUROXH9HXXAXVPEJFRSLOGRVGYZASTEBAQNXJJROCYRTDPYFUIQJVDHAKEG9YACV9HCP"
        + "JUEUKOYFNWDXCCJBIFQKYOXGRDHVTHEQUMHO999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
        + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
        + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
        + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
        + "999999999999999999999999999999999999999999999999999999999999999999999999999", 
        transaction.SignatureFragment.Value);

      Assert.AreEqual("999999999999999999999999999999999999999999999999999999999999999999999999999999999", transaction.Address.Value);
      Assert.AreEqual(0, transaction.Value);
      Assert.AreEqual("999999999999999999999999999", transaction.ObsoleteTag.Value);
      Assert.AreEqual(1480690413, transaction.Timestamp);
      Assert.AreEqual(1, transaction.CurrentIndex);
      Assert.AreEqual(1, transaction.LastIndex);
      Assert.AreEqual("NFDPEEZCWVYLKZGSLCQNOFUSENIXRHWWTZFBXMPSQHEDFWZULBZFEOMNLRNIDQKDNNIELAOXOVMYEI9PG", transaction.BundleHash.Value);
      Assert.AreEqual("TKORV9IKTJZQUBQAWTKBKZ9NEZHBFIMCLV9TTNJNQZUIJDFPTTCTKBJRHAITVSKUCUEMD9M9SQJ999999", transaction.TrunkTransaction.Value);
      Assert.AreEqual("TKORV9IKTJZQUBQAWTKBKZ9NEZHBFIMCLV9TTNJNQZUIJDFPTTCTKBJRHAITVSKUCUEMD9M9SQJ999999", transaction.BranchTransaction.Value);
      Assert.AreEqual("999999999999999999999999999", transaction.Tag.Value);
      Assert.AreEqual(1480690413, transaction.AttachmentTimestamp);
      Assert.AreEqual(1480690413, transaction.AttachmentTimestampLowerBound);
      Assert.AreEqual(1480690413, transaction.AttachmentTimestampUpperBound);
      Assert.AreEqual("999999999999999999999999999", transaction.Nonce.Value);
    }

    /// <summary>
    /// The test transaction generation from trytes with hash.
    /// </summary>
    [TestMethod]
    public void TestTransactionGenerationFromTrytesWithHash()
    {
      var hash = new Hash("TESTVALUE9DONTUSEINPRODUCTION99999VALCXCDHTDZBVCAAIEZCQCXGEFYBXHNDJFZEBEVELA9HHEJ");
      var transaction = Transaction.FromTrytes(GetTransactionTrytes(), hash);

      Assert.AreEqual("TESTVALUE9DONTUSEINPRODUCTION99999VALCXCDHTDZBVCAAIEZCQCXGEFYBXHNDJFZEBEVELA9HHEJ", transaction.Hash.Value);
    }

    /// <summary>
    /// The test transaction to tryte conversion.
    /// </summary>
    [TestMethod]
    public void TestTransactionToTryteConversion()
    {
      var transaction = new Transaction
                          {
                            Address = new Address("9XV9RJGFJJZWITDPKSQXRTHCKJAIZZY9BYLBEQUXUNCLITRQDR9CCD99AANMXYEKD9GLJGVB9HIAGRIBQ"), 
                            Tag = new Tag("PPDIDNQDJZGUQKOWJ9JZRCKOVGP"), 
                            ObsoleteTag = new Tag("PPDIDNQDJZGUQKOWJ9JZRCKOVGP"), 
                            Timestamp = 1509136296, 
                            CurrentIndex = 0, 
                            LastIndex = 0
                          };
      var transactionTrytes = transaction.SignatureValidationTrytes();

      Assert.AreEqual(
        "9XV9RJGFJJZWITDPKSQXRTHCKJAIZZY9BYLBEQUXUNCLITRQDR9CCD99AANMXYEKD9GLJGVB9HIAGRIBQ999999999999999999999999999PPDIDNQDJZGUQKOWJ9JZRCKOVGPXVBSEXD99999999999999999999", 
        transactionTrytes);
    }

    /// <summary>
    /// The test tryte string generation from transaction.
    /// </summary>
    [TestMethod]
    public void TestTryteStringGenerationFromTransaction()
    {
      var transaction = Transaction.FromTrytes(GetTransactionTrytes());
      var tryteString = transaction.ToTrytes();

      Assert.AreEqual(GetTransactionTrytes().Value, tryteString.Value);
    }

    #endregion

    #region Methods

    /// <summary>
    /// The get transaction trytes.
    /// </summary>
    /// <returns>
    /// The <see cref="TransactionTrytes"/>.
    /// </returns>
    private static TransactionTrytes GetTransactionTrytes()
    {
      return
        new TransactionTrytes(
          "GYPRVHBEZOOFXSHQBLCYW9ICTCISLHDBNMMVYD9JJHQMPQCTIQAQTJNNNJ9IDXLRCCOYOXYPCLR9PBEY9ORZIEPPDNTI9CQWYZUOTAVBXPSBOFEQAPFLWXSWUIUSJMSJIIIZ"
          + "WIKIRH9GCOEVZFKNXEVCUCIIWZQCQEUVRZOCMEL9AMGXJNMLJCIA9UWGRPPHCEOPTSVPKPPPCMQXYBHMSODTWUOABPKWFFFQJHCBVYXLHEWPD9YUDFTGNCYAKQKVEZYRBQRB"
          + "XIAUX9SVEDUKGMTWQIYXRGSWYRK9SRONVGTW9YGHSZRIXWGPCCUCDRMAXBPDFVHSRYWHGB9DQSQFQKSNICGPIPTRZINYRXQAFSWSEWIFRMSBMGTNYPRWFSOIIWWT9IDSELM9"
          + "JUOOWFNCCSHUSMGNROBFJX9JQ9XT9PKEGQYQAWAFPRVRRVQPUQBHLSNTEFCDKBWRCDX9EYOBB9KPMTLNNQLADBDLZPRVBCKVCYQEOLARJYAGTBFR9QLPKZBOYWZQOVKCVYRG"
          + "YI9ZEFIQRKYXLJBZJDBJDJVQZCGYQMROVHNDBLGNLQODPUXFNTADDVYNZJUVPGB9LVPJIYLAPBOEHPMRWUIAJXVQOEM9ROEYUOTNLXVVQEYRQWDTQGDLEYFIYNDPRAIXOZEB"
          + "CS9P99AZTQQLKEILEVXMSHBIDHLXKUOMMNFKPYHONKEYDCHMUNTTNRYVMMEYHPGASPZXASKRUPWQSHDMU9VPS99ZZ9SJJYFUJFFMFORBYDILBXCAVJDPDFHTTTIYOVGLRDYR"
          + "TKHXJORJVYRPTDH9ZCPZ9ZADXZFRSFPIQKWLBRNTWJHXTOAUOL9FVGTUMMPYGYICJDXMOESEVDJWLMCVTJLPIEKBE9JTHDQWV9MRMEWFLPWGJFLUXI9BXPSVWCMUWLZSEWHB"
          + "DZKXOLYNOZAPOYLQVZAQMOHGTTQEUAOVKVRRGAHNGPUEKHFVPVCOYSJAWHZU9DRROHBETBAFTATVAUGOEGCAYUXACLSSHHVYDHMDGJP9AUCLWLNTFEVGQGHQXSKEMVOVSKQE"
          + "EWHWZUDTYOBGCURRZSJZLFVQQAAYQO9TRLFFN9HTDQXBSPPJYXMNGLLBHOMNVXNOWEIDMJVCLLDFHBDONQJCJVLBLCSMDOUQCKKCQJMGTSTHBXPXAMLMSXRIPUBMBAWBFNLH"
          + "LUJTRJLDERLZFUBUSMF999XNHLEEXEENQJNOFFPNPQ9PQICHSATPLZVMVIWLRTKYPIXNFGYWOJSQDAXGFHKZPFLPXQEHCYEAGTIWIJEZTAVLNUMAFWGGLXMBNUQTOFCNLJTC"
          + "DMWVVZGVBSEBCPFSM99FLOIDTCLUGPSEDLOKZUAEVBLWNMODGZBWOVQT9DPFOTSKRABQAVOQ9RXWBMAKFYNDCZOJGTCIDMQSQQSODKDXTPFLNOKSIZEOY9HFUTLQRXQMEPGO"
          + "XQGLLPNSXAUCYPGZMNWMQWSWCKAQYKXJTWINSGPPZG9HLDLEAWUWEVCTVRCBDFOXKUROXH9HXXAXVPEJFRSLOGRVGYZASTEBAQNXJJROCYRTDPYFUIQJVDHAKEG9YACV9HCP"
          + "JUEUKOYFNWDXCCJBIFQKYOXGRDHVTHEQUMHO999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
          + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
          + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
          + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
          + "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999"
          + "999999999999999999999999999999999999999999999999999999999999999999999999999999RKWEEVD99A99999999A99999999NFDPEEZCWVYLKZGSLCQNOFUSENI"
          + "XRHWWTZFBXMPSQHEDFWZULBZFEOMNLRNIDQKDNNIELAOXOVMYEI9PGTKORV9IKTJZQUBQAWTKBKZ9NEZHBFIMCLV9TTNJNQZUIJDFPTTCTKBJRHAITVSKUCUEMD9M9SQJ999"
          + "999TKORV9IKTJZQUBQAWTKBKZ9NEZHBFIMCLV9TTNJNQZUIJDFPTTCTKBJRHAITVSKUCUEMD9M9SQJ999999999999999999999999999999999RKWEEVD99RKWEEVD99RKW"
          + "EEVD99999999999999999999999999999");
    }

    #endregion
  }
}