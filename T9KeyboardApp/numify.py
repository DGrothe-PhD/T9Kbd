def ifromchar(q):
    c = q.lower()
    if c < 'd':
        return 2
    elif c < 'g':
        return 3
    elif c < 'j':
        return 4
    elif c < 'm':
        return 5
    elif c < 'p':
        return 6
    elif c < 't':
        return 7
    elif c < 'w':
        return 8
    else:
        return 9

def numify(text):
    result = ""
    for x in text:
        if x.isalpha():
            result += str(ifromchar(x))
        else:
            result += x
    return result

def jsonify(text):
    word = text.split()
    for w in word:
        print(f'"{numify(w)}" : [ "{w}" ],')

# numify("Auf Wiedersehen!")
# '283 94333773436!'