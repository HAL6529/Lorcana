using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_10 : CardInfo
{
    public CardInfo_185_JA_10()
    {
        this.cardNo = "185_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ボゴ署長";
        this.cardName2 = "仕切る指揮官";
        this.power = 4;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarcoGuadalupi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
