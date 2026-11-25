using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_13 : CardInfo
{
    public CardInfo_047_JA_13()
    {
        this.cardNo = "047_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミーコ";
        this.cardName2 = "ツイてるアライグマ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
