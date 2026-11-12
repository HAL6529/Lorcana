using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_07 : CardInfo
{
    public CardInfo_142_JA_07()
    {
        this.cardNo = "142_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ÉoÉãÅ[";
        this.cardName2 = "ìSÇÃí‹ÇÃêÊê∂";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SergioMancinelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
