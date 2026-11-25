using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_099_JA_13 : CardInfo
{
    public CardInfo_099_JA_13()
    {
        this.cardNo = "099_JA_13";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス＆ミニーマウス";
        this.cardName2 = "大冒険カップル";
        this.power = 5;
        this.toughness = 5;
        this.lore = 5;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Team, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.DuoShift0 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
