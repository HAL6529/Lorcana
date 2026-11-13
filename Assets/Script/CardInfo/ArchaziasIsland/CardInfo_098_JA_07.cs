using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_098_JA_07 : CardInfo
{
    public CardInfo_098_JA_07()
    {
        this.cardNo = "098_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "活発な海賊";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
