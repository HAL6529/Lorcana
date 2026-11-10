using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_04 : CardInfo
{
    public CardInfo_185_JA_04()
    {
        this.cardNo = "185_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ñÇñ@ÇÃÇŸÇ§Ç´";
        this.cardName2 = "ãÛîÚÇ‘ê¥ë|åW";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlibethZermeno;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Broom};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
