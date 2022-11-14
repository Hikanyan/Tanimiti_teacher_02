using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LinqQue : MonoBehaviour
{
    [SerializeField] CharacterMaster date;
    void Start()
    {
        var query = date.sheet
                    .Where (x =>x.Hp > 60)//�����Ɉ�v������̂��i�荞��
                    .OrderBy (x => x.Hp)//�w��L�[�������Ń\�[�g����
                    .Select (x => x.Name);//�v�f�i�\�̏c�̗�j��I������
        foreach(var name in query)
        {
            Debug.Log(name);
        }
    }
}
