import sys
import Francis_Bacon_Cipher as cipher

# Количество аргументов командной строки
arg_count  = len(sys.argv) - 1;
chiper_key = "aaaaabbbbbabbbaabbababbaaababaab";

if arg_count == 3 and sys.argv[1] == 'encode':
    # text = "Prometheus"
    # sentence = "Welcome to the Hotel California Such a lovely place Such a lovely place"
    text = str(sys.argv[2]);
    sentence = str(sys.argv[3]);
    print("Результат: " + cipher.encoder(text, sentence, chiper_key));
elif arg_count == 2 and sys.argv[1] == 'decode':
    # text = "Hot sUn BEATIng dOWN bURNINg mY FEet JuSt WalKIng arOUnD HOt suN mAkiNG me SWeat"
    text = str(sys.argv[2]);
    print("Результат: " + cipher.decoder(text, chiper_key));








