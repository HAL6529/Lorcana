using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_08 : CardInfo
{
    public CardInfo_140_JA_08()
    {
        this.cardNo = "140_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "コーチマン";
        this.cardName2 = "貪欲な騙し屋";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
