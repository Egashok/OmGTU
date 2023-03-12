#Ввод : ребро1 ребро2 вес

ribrs=[]
peaks=""
opPeaks=""
#задействованные вершины
score=0
inpRibrs = input()

while inpRibrs !='':
    ribrsStr = [inpRibrs.split()[0], inpRibrs.split()[1], int(inpRibrs.split()[2])]
    if ribrsStr[0] not in peaks:
        peaks += ribrsStr[0]
    if ribrsStr[1] not in peaks:
        peaks += ribrsStr[1]
    score = max(score, ribrsStr[2])
    ribrs.append(ribrsStr)
    inpRibrs = input()

#Получаем ребра и их веса

d = [score]*len(peaks)
#Даем максимальные значения верщинам

a = int(input('От куда:')) - 1
b = int(input('Куда:')) - 1

#Вводим точки отправления,прибытия и убавляем до индекса

opPeaks = str(a + 1)
for i in range(len(d)):
    for j in range(len(ribrs)):
        if ribrs[j][0] == str(a + 1) and ribrs[j][1] == str(i+1):
            d[i] = ribrs[j][2]
#находим ребра для первой вершины

min_val = score
min_peak = None
for i in range(len(d)):
    if d[i] < min_val and str(i+1) not in opPeaks:
        min_val = d[i]
        min_peak = i
a = min_peak
#ищем минимальное для первой вершины
while a != None:
    opPeaks += str(a + 1)
    for i in range(len(d)):
        for j in range(len(ribrs)):
            if ribrs[j][0] == str(a + 1) and ribrs[j][1] == str(i+1):
                d[i] = min(ribrs[j][2] + d[a], d[i])
    min_val = score
    min_peak = None
    for i in range(len(d)):
        if d[i] < min_val and str(i+1) not in opPeaks:
            min_val = d[i]
            min_peak = i
    a = min_peak
#ищем минимальные для остальных
#d[b]-вес конечной вершины
print(d[b])


