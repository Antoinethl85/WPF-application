<h1>WPF application</h1>

<p>This TP was made by Antoine Thielin, Isaac Charaf and Guillaume André.</p>

<h2>Summary</h2>

<ul>
  <li>What is AES?</li>
  <li>Our work</li>
  <li>Bibliography</li>
</ul>

<h2>What is AES?</h2>

<p>The Advanced Encryption Standard (AES) is a symmetric block cipher chosen by the US government to protect classified information.
How AES encryption works
AES includes three block ciphers:

AES-128 uses a 128-bit key length to encrypt and decrypt a block of messages.
AES-192 uses a 192-bit key length to encrypt and decrypt a block of messages.
AES-256 uses a 256-bit key length to encrypt and decrypt a block of messages.Each cipher encrypts and decrypts data in 128-bit blocks using 128-, 192- and 256-bit cryptographic keys, respectively.

Symmetric, also known as secret key, encryptions use the same key to encrypt and decrypt. Both the sender and receiver must know - and use - the same secret key.</p>

<h2>Our work</h2>

<p>First of all, we started by the structure. So, we edited the .xaml file to have a clear and simple visual interface. AFter that, we went into the hardest part. We learnt about AES encryption algorithm (not enough because we were a bit late in our work) and started the implementationof this algorithm.</p>
<p>So, basicly our application is divided in 2 parts : decryption and encryption. You need to enter the code you want to decrypt/encrypt, you also need a key and an initialization vector. Then, you just have to press the button and the app will run (<strong>I don't know why it doesn't work i tried multiple things to fix this but failed every time ...</strong>).</p>

<h2>Bibliography</h2>

<ul>
  <li>https://docs.microsoft.com/en-us/dotnet/desktop/wpf/get-started/create-app-visual-studio?view=netdesktop-5.0</li>
  <li>https://fr.wikipedia.org/wiki/Advanced_Encryption_Standard</li>
  <li>https://docs.microsoft.com/fr-fr/dotnet/api/system.security.cryptography.rijndael?view=net-5.0</li>
  <li>https://webman.developpez.com/articles/dotnet/aes-rijndael/</li>
</ul>
