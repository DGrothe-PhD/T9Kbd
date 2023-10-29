import json

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
    with open(f"T9.json") as jsd:
        json_data = json.load(jsd)
    jsd.close()
    #
    word = text.split()
    for x in word:
        w = x.strip(".,;:-!?'")
        textkey = numify(w)
        if not textkey in json_data:
            json_data[textkey] = [ w ]
        else:
            entry = json_data[textkey]
            if not w in entry:
                entry.append(w)
                json_data[textkey] = entry
    # TODO testing, writing to file
    print(json_data)
        #print(f'"{numify(w)}" : [ "{w}" ],')

# numify("Auf Wiedersehen!")
# '283 94333773436!'
