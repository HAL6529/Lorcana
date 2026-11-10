using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_02 : CardInfo
{
    public CardInfo_153_JA_02()
    {
        this.cardNo = "153_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ジャドソン夫人";
        this.cardName2 = "家政婦";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
