using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_08 : CardInfo
{
    public CardInfo_115_JA_08()
    {
        this.cardNo = "115_JA_08";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "いまカオス！終わりを！告げたぁ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether8 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
