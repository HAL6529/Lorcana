using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_166_JA_07 : CardInfo
{
    public CardInfo_166_JA_07()
    {
        this.cardNo = "166_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マリー";
        this.cardName2 = "おひめさまキャット";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
