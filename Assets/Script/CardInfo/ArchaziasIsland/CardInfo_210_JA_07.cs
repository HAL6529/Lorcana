using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_210_JA_07 : CardInfo
{
    public CardInfo_210_JA_07()
    {
        this.cardNo = "210_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "新たなる戴冠者";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
