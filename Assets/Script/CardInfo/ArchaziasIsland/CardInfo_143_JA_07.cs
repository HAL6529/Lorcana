using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_07 : CardInfo
{
    public CardInfo_143_JA_07()
    {
        this.cardNo = "143_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉâÉeÉBÉKÉì";
        this.cardName2 = "ã…à´î∆çﬂé“";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
