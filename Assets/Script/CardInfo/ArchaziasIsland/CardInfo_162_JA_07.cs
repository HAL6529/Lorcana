using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_07 : CardInfo
{
    public CardInfo_162_JA_07()
    {
        this.cardNo = "162_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "タマトア";
        this.cardName2 = "ゴージャス！";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
