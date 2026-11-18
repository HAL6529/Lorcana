using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_08 : CardInfo
{
    public CardInfo_059_JA_08()
    {
        this.cardNo = "059_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マダム・ミム";
        this.cardName2 = "よからぬたくらみ中";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
