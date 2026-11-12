using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_07 : CardInfo
{
    public CardInfo_113_JA_07()
    {
        this.cardNo = "113_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アナスタシア";
        this.cardName2 = "いばりんぼうの義姉";
        this.power = 3;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
