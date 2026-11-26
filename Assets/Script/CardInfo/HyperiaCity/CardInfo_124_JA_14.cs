using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_14 : CardInfo
{
    public CardInfo_124_JA_14()
    {
        this.cardNo = "124_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ロクサーヌ";
        this.cardName2 = "私をコンサートに連れてって";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
