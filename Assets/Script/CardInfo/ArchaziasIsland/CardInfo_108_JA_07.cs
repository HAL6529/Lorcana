using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_07 : CardInfo
{
    public CardInfo_108_JA_07()
    {
        this.cardNo = "108_JA_07";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "多才な海賊";
        this.power = 6;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
