using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_02 : CardInfo
{
    public CardInfo_126_JA_02()
    {
        this.cardNo = "126_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "シア・カーン";
        this.cardName2 = "脅威の肉食獣";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.M_RobertDaviesAndL_Giammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
