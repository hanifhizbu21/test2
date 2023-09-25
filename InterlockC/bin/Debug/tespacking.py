from pyModbusTCP.client import ModbusClient
import time
import os
import mysql.connector
import datetime

db = mysql.connector.connect(
  host="10.11.1.44",
  user="p1_server",
  passwd="motasa",
  database="p2_packing_multiline"
)

ip_m = []
id_modbus = []
id_modbus1 = []
status_m = []
status_p = []
status_pintu = ""
status_mesinlive = ""
global counter

def show_data(db):
  try:
    db.connect()
    cursor = db.cursor()
    sql = "SELECT * FROM multiline"
    cursor.execute(sql)
    x = cursor.fetchall() 
    if cursor.rowcount < 0:
      print("Tidak ada data")
    else:
        for y in x:
          ip_m.append(y[2])
          id_modbus.append(y[5])
          id_modbus1.append(y[6])
          #status_m.append(y[5])
          #status_p.append(y[8])
          print("--------------------------------")
          print (ip_m,"  ",id_modbus,"  ",id_modbus1)
          print("--------------------------------")
  except:
    print("error show")
    db.close()
  finally:
    db.close()

def update_data(db):
  try:
    db.connect()
    cursor = db.cursor()
    sql = """UPDATE multiline SET data1=%s WHERE id_d1=%s AND ip_mesin=%s"""
    val = (hasilfix, id_modbus[i], ip_m[i])
    print(val)
    cursor.execute(sql, val)
    db.commit()
    print("{} data berhasil diubah".format(cursor.rowcount))
  except:
    print("error update")
  finally:
    db.close()

def update_dataX(db):
  try:
    db.connect()
    cursor = db.cursor()
    datatime = datetime.datetime.now()
    dataT = str(datatime)
    timed = dataT.split(".")
    timex = timed[0]
    sql = """UPDATE multiline SET status_mesin=%s, waktu=%s WHERE id_d2=%s AND ip_mesin=%s"""
    val = (status_mesinlive, datatime, id_modbus1[i], ip_m[i])
    print(val)
    cursor.execute(sql, val)
    db.commit()
    print("{} data berhasil diubah".format(cursor.rowcount))
  except:
    print("error update")
  finally:
    db.close()

while True:
    time.sleep(0.5)
    os.system('cls')
    ip_m = []
    id_modbus = []
    id_modbus1 = []
    #status_m = []
    #status_p = []
    show_data(db)
    for i in range(0,5):
      try:
        c = ModbusClient(host=ip_m[i],port=502, auto_open=True, auto_close=True)
        #coildt=c.write_single_coil(id_modbus[i], status_m[i])
        regs = c.read_holding_registers(id_modbus[i],2)
        hasil1 = regs[1] * 65536
        hasilfix = hasil1 + regs[0]
        regsX = c.read_coils(id_modbus1[i],1)
        data_count = regs
        if regsX[0] == True:
            status_mesinlive = "On"
        elif regsX[0] == False:
            status_mesinlive = "OFF"
        print(i," : ","--", hasilfix ,"--",regsX[0])
        update_data(db)
        update_dataX(db)
      except:
        pass
