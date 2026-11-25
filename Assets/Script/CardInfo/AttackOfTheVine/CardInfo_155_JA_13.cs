using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_13 : CardInfo
{
    public CardInfo_155_JA_13()
    {
        this.cardNo = "155_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "知りたがりの探検家";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DavidOtalora;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
