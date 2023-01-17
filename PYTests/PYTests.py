
# urllib3.disable_warnings(urllib3.exceptions.InsecureRequestWarning)
# import sys
# sys.path.append("C:/Workspacezan/TestsTests/PYTests/Def/Def.py")

# _archivo = "MT940_4203_MXCOSMICIPS-20220902005951869"
# String_Split(_archivo)
#import requests
#import json
#import urllib3
#import urllib
#import os
#from tkinter import *
#from tkinter.ttk import *
#import time


def String_Split():
   _archivo = "MT940_4203_MXCOSMICIPS-20220902005951869"
    _split = _archivo.split("-")
    _item = _split[1]
    index = [0, 4, 6, 8]
    parts = [_item[i:j] for i, j in zip(index, index[1:] + [None])]
    print(parts[2])


# Test de Formateo de Fecha
def Date_Formatting():
    d1 = "960825"
    d2 = "0825"
    result = []
    result2 = []
    for i in range(0, len(d1), 2):
        result.append(d1[i : i + 2])
        y = result[0]
    for i in range(0, len(d2), 2):
        result2.append(d2[i : i + 2])
    if len(result) <= 6:
        print(result[2] + "/" + result[1] + "/19" + result[0])
    if len(result2) <= 4:
        print(result2[1] + "/" + result2[0] + "/19" + y)


# Test de Formateo de Monto
def Amount_Formatting():
    amount = "264505,15"
    min = 0
    while amount.startswith("0"):
        amount = amount[min + 1 : len(amount)]
    print(amount.replace(",", "."))


# Test de un API
def Api_Request():
    urls = [
        "https://localhost:44365/api/CatalogoBu/get",
        "https://localhost:44365/api/CatalogoBanco/get",
        "https://localhost:44365/api/CatalogoMoneda/get",
        "https://localhost:44365/api/CatalogoMese/get",
        "https://localhost:44365/api/BitacoraArchivo/get",
    ]
    response_API = requests.get(urls[4], verify=False)
    data = json.loads(response_API.text)
    lst = []
    count = 0
    for z in data["data"]:
        estatus = z["estatus"]
        if estatus:
            count += 1
            nombre = z["nombre"]
            lst.append(nombre)
    print(lst)
    print(count)


def Api_Request_Archivo():
    # urls = 'https://localhost:44365/api/BitacoraArchivo/get'
    # response_API = requests.get(urls, verify = False)
    # data= json.loads(response_API.text)
    # _nombreNuevo = "PruebaAPIMT2"
    # _count = 1
    # _count2 = 1
    # for z in data['data']:
    #    _nombre = z['nombreArchivo']
    #    if(_nombre == _nombreNuevo):
    #        _count += 1
    #    else:
    #        _count2 = 1
    # print(_count)
    # print(_count2)
    urls = "https://localhost:44365/api/BitacoraArchivo/get"
    response_API = requests.get(urls, verify=False)
    data = json.loads(response_API.text)
    _nombreNuevo = "PruebaAPIMT2"
    _aux = 0
    _aux2 = 0
    for z in data["data"]:
        _nombre = z["nombreArchivo"]
        _count = z["idConsecutivo"]
        _count2 = z["idConsecutivo"]
        if _nombre == _nombreNuevo:
            _count += 1
            _aux = _count
        if _aux == 0:
            _aux = 1
    print(_aux)


def Api_Post():
    headers = {"Content-type": "application/json", "Accept": "application/json"}

    url = "https://localhost:44365/api/BitacoraArchivo/post"
    data = {"nombreArchivo": "PruebaAPIMT2", "idConsecutivo": 2}
    rqt = requests.post(url, json=data, headers=headers, verify=False)

    print(rqt.text)


def Extra_Tests():
    _archivo = "BU_ANG-CRISTOBAL COLON-MXN-Noviembre-2022(2)"
    print(len(_archivo))


def Find_Char():
    _string = ":61:2108030803D000000019609,98NTRF0000225927//1523"
    tag = _string.split("//", 1)
    urls = "https://localhost:44365/api/CatalogoCodigo/get"
    params = {"codigo": tag[1]}
    response_API = requests.get(urls, params=params, verify=False)
    data = response_API.json()
    lst = []
    # count = 0
    # for z in data['data']:
    #    estatus = z['codMt']
    #    if(estatus):
    #        count += 1
    #        nombre = z['nombre']
    lst.append(data["data"]["codMt"])
    lst.append(data["data"]["codDescripcion"])
    print(lst)


def Api_DownloadExcel_Get():
    path = "C:/MT940/Creados"
    url = "https://localhost:44365/api/Excel/DownloadExcel"
    # Si el Path existe o no será creado
    isExist = os.path.exists(path)
    if isExist:
        urllib.request.urlretrieve(
            url, "C:/MT940/CashManagementBankStatementImportTemplate.xlsm"
        )  # For Python 3
    else:
        os.makedirs(path)
        urllib.request.urlretrieve(
            url, "C:/MT940/CashManagementBankStatementImportTemplate.xlsm"
        )  # For Python 3


import asyncio

# Uso de Async
def Countdown():
    maxValue = 9
    minValue = 0
    while minValue <= maxValue:
        minValue += 1
        print(minValue)


def Progress():
    window = Tk()
    bar = Progressbar(window, orient=HORIZONTAL, length=300)
    bar.pack(pady=10)
    button = Button(window, text="Descargar", command=Countdown).pack()
    window.mainloop()


def TkinterTest():
    # Frame windows
    frame = tk.Tk()
    frame.wm_state("iconic")
    frame.title("Progreso de Descarga")
    frame.geometry("300x100")
    frame.resizable(0, 0)
    frame.deiconify()
    frame.grid()
    frame.mainloop()
