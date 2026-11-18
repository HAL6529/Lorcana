using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_08 : CardInfo
{
    public CardInfo_174_JA_08()
    {
        this.cardNo = "174_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ゼペット";
        this.cardName2 = "腕利きの職人";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
