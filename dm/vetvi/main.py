import math
way = 0
matrix = [[math.inf, 6, 4, 8, 7],
         [6, math.inf, 7, 11, 7],
          [4, 7, math.inf, 4, 3],
          [8, 11, 4, math.inf, 5],
         [7, 7, 3, 5, math.inf]]

while len(matrix) != 1:
    minway = 0
    for string in matrix:
        min_weight = string[0]
        min_index = 0

        for weight in string:
            if weight < min_weight:
                min_weight = weight
        for i in range(len(string)):
            string[i] -= min_weight
        minway += min_weight

    for i in range(len(matrix)):
        min_weight = matrix[0][0]
        min_index = 0

        for j in range(len(matrix)):
            if matrix[j][i] < min_weight:
                min_weight = matrix[j][i]
                min_index = j

        for j in range(len(matrix)):
            matrix[j][i] -= min_weight
        
        minway += min_weight

    maxnol = 0
    inol = 0
    jnol = 0
    for i in range(len(matrix)):
        for j in range(len(matrix)):
            if matrix[i][j] == 0:
                minstr = math.inf
                mincol = math.inf
                for r in matrix[i][0:j] + matrix[i][j+1:]:
                    minstr = min(minstr, r)
                for g in range(len(matrix)):
                    if g != i:
                        mincol = min(mincol, matrix[g][j])

                if minstr + mincol >maxnol:
                    maxnol = minstr + mincol
                    inol = i
                    jnol = j
   # print(minstr)
    matrix[jnol][inol] = math.inf
    matrix.pop(inol)
    for i in range(len(matrix)):
        matrix[i].pop(jnol)
    way += minway
print(way)