using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_131_JA_07 : CardInfo
{
    public CardInfo_131_JA_07()
    {
        this.cardNo = "131_JA_07";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "トビー";
        this.cardName2 = "ワンパクな仲間";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
