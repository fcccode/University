import os
# read from file
def read(path,filename, count = 1):
    '''
    Read from file
    '''
    l = path + filename
    assert filename != '' or path != ''
    f = open(l, 'r')
    if count == 1:
        temp = f.read()
    else:
        temp = f.read(count)
    f.close()
    return temp



# write to file
def write(path, filename, line):
    '''
    write to file
    '''
    l = path + filename
    assert filename != '' or path != ''
    f = open(l, 'w')
    f.write(line)
    f.close()
    return "Успешно"

# rewrite file
def writeAppend(path, filename, line):
    '''
    rewrite
    '''
    l = path + filename
    assert filename != '' or path != ''
    f = open(l, 'a')
    f.write(line)
    f.close()
    return "Успешно"

#
def findFileInCatalog(path, line):
    '''
    find file in catalog
    '''
    cons = []
    for d, dirs, files in os.walk(path):
       for f in files:
           cons.append(f)

    if line in cons:
        return True
    else:
        return False
    
      
# find da in file
def findDataInFile(path, filename, data):
    '''
    find data in file
    '''
    l = path + filename
    assert filename != '' or path != ''
    f = open(l, 'r')
    temp = f.read()
    if data in temp:
        return True
    else:
        return False
    
        
          

    
# sort data 
def sort(path, filename):
    '''
    sort data
    '''
    points = {}
    l = path+filename
    for line in open(l):
        (val, key) = line.split()
        points[int(val)] = key 

    l = lambda x: x[0]
    m= sorted(points.items(), key=l, reverse=False)
    
    return m    


