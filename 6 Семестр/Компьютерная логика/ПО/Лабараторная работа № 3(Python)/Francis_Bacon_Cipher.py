#! Шифр Френсиса Бекона
import string
'''   Генерация таблицы для кодирования и декодирования шифра Бекона по ключу '''
def create_table(key,type):
    if not isinstance(key, str) or len(key) < 32:
        return 'Error';
    encode_table = {}
    decode_table = {}
    alpha = string.ascii_lowercase;
    for i in range(len(alpha)):
        encode = {alpha[i]: str(key[i:i + 5])}
        encode_table.update(encode);
        decode = {str(key[i:i + 5]):alpha[i]}
        decode_table.update(decode);
    if type == 'encode':
        return  encode_table;
    elif type == 'decode':
        return  decode_table;

''' Раскодирование шифра Бекона '''
def decoder(text,key):
    converted_text = ''
    logic_conclus_len = 0;
    decoded_list = []
    decoded_text = ''
    resource = create_table(key, 'decode')
    # ******************Определение текста который несет только закодированный текст**************************
    text = text.replace(' ','');       
    text_len =  len(text);
    # Определение остатка логического завершения текста
    logic_conclus_len = text_len%5;
    # Разделения текста от остатка
    text = text[:text_len - logic_conclus_len];
    # Конвертирование текста в представление ab группы
    for char in text :
        if char.isupper():
            converted_text = converted_text + 'b'
        else :
            converted_text = converted_text + 'a'
    
    # ************Представление текста в виде списка по 5 символов**********************************
    for i in range(0, len(converted_text), 5):    # 2
        decoded_list.append(converted_text[i:i + 5]);
    # ************* Расшифровка текста**************************************************************
    #
    for item in decoded_list:
        if item in resource:
            decoded_text = decoded_text + resource.get(item);
    # ****************Результат расшифрованный текст*************************************************
    return decoded_text;

''' Шифрация текста при помощи шифра Бекона '''
def encoder(text, sentence, key):
    logic_conclus_ofsentecte = ''
    converted_text = ''             # Представление текста в "аb" формате
    text = text.lower();            # Перевод текста в нижний регистр
    need_len_toencode = 0;          # Количество символов необходимых для сохранения кода
    coded_text = ''
    help_iteator = 0;
    # Набор правил шифрации
    resource = create_table(key, 'encode')
    # ****************Преобразование текста в код Френсиса ***********************************
    for char in text:
        if char in resource:
            converted_text = converted_text + resource.get(char);
    # *****************************************************************************************
    # Определение длины фразы не теряя пробелов и логики предложения
    while need_len_toencode < len(converted_text):
        if sentence[help_iteator] != ' ':
            need_len_toencode += 1;
        if len(sentence) < help_iteator :
            sentence = sentence*2
        help_iteator += 1;

    temp = help_iteator;
    # *****************Определение логичного завершения фразы**********************************
    while sentence[temp] != ' ' or help_iteator >= len(sentence):
        logic_conclus_ofsentecte = logic_conclus_ofsentecte + sentence[temp];
        temp += 1;
    # ***************предложение которое будет преобразовываться*******************************
    sentence = sentence[:help_iteator];
    help_iteator =0;
    # ***************Кодировка теста в предложении**********************************************
    for i in range(len(sentence)):
        # Преобразовываем только буквы
        char = str(sentence[i]);
        if char.isalpha():
            if converted_text[help_iteator] == 'a':
                coded_text = coded_text + char.lower();
                help_iteator += 1;
            elif converted_text[help_iteator] == 'b':
                coded_text = coded_text + char.upper();
                help_iteator += 1;
        # Остальные символы добавляем в последовательность
        else:
            coded_text = coded_text + char;
    # **********************************************************************************************
    return  coded_text + logic_conclus_ofsentecte;

