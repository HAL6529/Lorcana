using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_04 : CardInfo
{
    public CardInfo_190_JA_04()
    {
        this.cardNo = "190_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ピロクテテス";
        this.cardName2 = "ド根性トレーナー";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
