using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_07 : CardInfo
{
    public CardInfo_053_JA_07()
    {
        this.cardNo = "053_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マダム・メデューサ";
        this.cardName2 = "ダイヤに首ったけ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RogerPerez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
