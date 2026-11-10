using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_04 : CardInfo
{
    public CardInfo_069_JA_04()
    {
        this.cardNo = "069_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉNÉäÉLÅ[";
        this.cardName2 = "çKâ^ÇÃÉRÉIÉçÉM";
        this.power = 3;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
