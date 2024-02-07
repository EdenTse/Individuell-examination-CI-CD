//namespace CaesarCipherTests;

using MyApp;
using Xunit;

public class CaesarCipherTests
{
    [Fact]
    public void Encrypt_ShouldEncryptTextCorrectly()
    {
        // Arrange
        string plainText = "Hello, World!";
        int shift = 3;

        // Act
        string encryptedText = CaesarCipher.Encrypt(plainText, shift);

        // Assert
        Assert.Equal("Khoor, Zruog!", encryptedText);
    }

    [Fact]
    public void Decrypt_ShouldDecryptTextCorrectly()
    {
        // Arrange
        string cipherText = "Khoor, Zruog!";
        int shift = 3;

        // Act
        string decryptedText = CaesarCipher.Decrypt(cipherText, shift);

        // Assert
        Assert.Equal("Hello, World!", decryptedText);
    }
}
