using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_13 : CardInfo
{
    public CardInfo_046_JA_13()
    {
        this.cardNo = "046_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ビクシー";
        this.cardName2 = "魚取りの名人";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
