using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_11 : CardInfo
{
    public CardInfo_112_JA_11()
    {
        this.cardNo = "112_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エリサ・マーザ";
        this.cardName2 = "ガーゴイル化";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Gargoyle, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
